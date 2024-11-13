namespace ApiUniversity.Models;

// Data Transfer Object class, used to bypass navigation properties validation during API calls
public class CourseDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int Credits { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new();
    public Department Department { get; set; }  // Ajout de la relation avec Department
    public List<Instructor> Instructors { get; set; }

    public CourseDTO() { }

    public CourseDTO(Course course)
    {
        Id = course.Id;
        Title = course.Title;
        Credits = course.Credits;
        Enrollments=course.Enrollments;
        Department = course.Department; // Ajout de la relation avec Department
        Instructors = course.Instructors;
    }
}