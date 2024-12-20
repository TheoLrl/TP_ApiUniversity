namespace ApiUniversity.Models;

public class Student
{
    public int Id { get; set; }
    public string LastName { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public DateTime EnrollmentDate { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new();

    //ajout 
    public string Email { get; set; } = null!;

    // Default constructor
    public Student() {}
    public Student(StudentDTO studentDTO)
    {
        Id = studentDTO.Id;
        FirstName = studentDTO.FirstName;
        LastName = studentDTO.LastName;
        EnrollmentDate = studentDTO.EnrollmentDate;
        
    }
}