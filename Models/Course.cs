namespace ApiUniversity.Models;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Credits { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new();

    public Department Department { get; set; }  // Ajout de la relation avec Department
    public List<Instructor> Instructors { get; set; }

    public Course() { }

    public Course(CourseDTO courseDTO)
    {
        Id = courseDTO.Id;
        Title = courseDTO.Title;
        Credits = courseDTO.Credits;
        Enrollments = courseDTO.Enrollments;
        Department = courseDTO.Department;
        Instructors = courseDTO.Instructors;
    }

}