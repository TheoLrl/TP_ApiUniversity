using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiUniversity.Models;

namespace ApiUniversity.Controllers;

[ApiController]
[Route("api/Student")]
public class StudentController : ControllerBase
{
    private readonly UniversityContext _context;

    public StudentController(UniversityContext context)
    {
        _context = context;
    }

    // GET: api/Student
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDTO>>> GetStudents()
    {
        // Get Students and related lists
        var Students = _context.Students.Select(x => new StudentDTO(x));
        return await Students.ToListAsync();
    }

    // GET: api/Student/2
    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDTO>> GetStudent(int id)
    {
        // Find todo and related list
        // SingleAsync() throws an exception if no todo is found (which is possible, depending on id)
        // SingleOrDefaultAsync() is a safer choice here
        var Student = await _context.Students.Include(t => t.Enrollments).SingleOrDefaultAsync(t => t.Id == id);

        if (Student == null) return NotFound();

        return new StudentDTO(Student);
    }

    // POST: api/Student
    [HttpPost]
    public async Task<ActionResult<Student>> PostStudent(StudentDTO studentDTO)
    {
        Student student = new(studentDTO);

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, new StudentDTO(student));

    }

    // PUT: api/Student/2
    [HttpPut("{id}")]
    public async Task<IActionResult> PutStudent(int id, StudentDTO studentDTO)
    {
        if (id != studentDTO.Id) return BadRequest();

        Student student = new(studentDTO);
        _context.Entry(student).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Students.Any(m => m.Id == id))
                return NotFound();
            else
                throw;
        }

        return NoContent();
    }

    // DELETE: api/Student/2
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudentItem(int id)
    {
        var Student = await _context.Students.FindAsync(id);

        if (Student == null)
            return NotFound();

        _context.Students.Remove(Student);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}