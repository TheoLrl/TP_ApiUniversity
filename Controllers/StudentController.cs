using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiUniversity.Models;

namespace ApiUniversity.Controllers;

[ApiController]
[Route("api/student")]
public class StudentController : ControllerBase
{
    private readonly UniversityContext _context;

    public StudentController(UniversityContext context)
    {
        _context = context;
    }

    // GET: api/student
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
    {
        // Get students and related lists
        var students = _context.Students;
        return await students.ToListAsync();
    }

    // // GET: api/student/2
    // [HttpGet("{id}")]
    // public async Task<ActionResult<Student>> GetTodo(int id)
    // {
    //     // Find todo and related list
    //     // SingleAsync() throws an exception if no todo is found (which is possible, depending on id)
    //     // SingleOrDefaultAsync() is a safer choice here
    //     var todo = await _context.Todos.Include(t => t.List).SingleOrDefaultAsync(t => t.Id == id);

    //     if (todo == null)
    //         return NotFound();

    //     return todo;
    // }

    // // POST: api/todo
    // [HttpPost]
    // public async Task<ActionResult<Todo>> PostTodo(Todo todo)
    // {
    //     _context.Todos.Add(todo);
    //     await _context.SaveChangesAsync();

    //     return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
    // }

    // // PUT: api/todo/2
    // [HttpPut("{id}")]
    // public async Task<IActionResult> PutTodo(int id, Todo todo)
    // {
    //     if (id != todo.Id)
    //         return BadRequest();

    //     _context.Entry(todo).State = EntityState.Modified;

    //     try
    //     {
    //         await _context.SaveChangesAsync();
    //     }
    //     catch (DbUpdateConcurrencyException)
    //     {
    //         if (!_context.Todos.Any(m => m.Id == id))
    //             return NotFound();
    //         else
    //             throw;
    //     }

    //     return NoContent();
    // }

    // // DELETE: api/todo/2
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteTodoItem(int id)
    // {
    //     var todo = await _context.Todos.FindAsync(id);

    //     if (todo == null)
    //         return NotFound();

    //     _context.Todos.Remove(todo);
    //     await _context.SaveChangesAsync();

    //     return NoContent();
    // }
}