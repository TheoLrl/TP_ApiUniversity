using Microsoft.EntityFrameworkCore;
using ApiUniversity.Models;

public class UniversityContext : DbContext
{
  public DbSet<Student> Students { get; set; } = null!;
  public DbSet<Enrollment> Enrollments { get; set; } = null!;
  public DbSet<Course> Courses { get; set; } = null!;

  public DbSet<Department> Departments { get; set; }
  public DbSet<Instructor> Instructors { get; set; }


  //    public DbSet<Grade> Grades  { get; set; } = null!; PAS BESOIN 
  public string DbPath { get; private set; }


  public UniversityContext()
  {
    // Path to SQLite database file
    DbPath = "ApiUniversity.db";
  }


  // The following configures EF to create a SQLite database file locally
  protected override void OnConfiguring(DbContextOptionsBuilder options)
  {
    // Use SQLite as database
    options.UseSqlite($"Data Source={DbPath}");
    // Optional: log SQL queries to console
    //options.LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information);
  }
}