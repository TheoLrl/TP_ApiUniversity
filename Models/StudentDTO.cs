namespace ApiUniversity.Models;
public class StudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime EnrollmentDate { get; set; }

    public StudentDTO() { }

    // Constructeur à partir d'un Student
    public StudentDTO(Student student)
    {
        Id = student.Id;
        FirstName = student.FirstName;
        LastName = student.LastName;
        EnrollmentDate = student.EnrollmentDate;
    }
}