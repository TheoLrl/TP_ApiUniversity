using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ApiUniversity.Models;

[ApiController]
[Route("api/instructor")]
public class InstructorController : ControllerBase
{
    private readonly UniversityContext _context;

    public InstructorController(UniversityContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<InstructorDTO>> CreateInstructor(InstructorDTO instructorDTO)
    {
        var instructor = new Instructor
        {
            FirstName = instructorDTO.FirstName,
            LastName = instructorDTO.LastName
        };

        _context.Instructors.Add(instructor);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetInstructorById), new { id = instructor.Id }, new InstructorDTO(instructor));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<InstructorDTO>> GetInstructorById(int id)
    {
        var instructor = await _context.Instructors
            .Include(i => i.AdministeredDepartments)
            .Include(i => i.Courses)
            .FirstOrDefaultAsync(i => i.Id == id);

        if (instructor == null)
        {
            return NotFound();
        }

        return new InstructorDTO(instructor);
    }
}
