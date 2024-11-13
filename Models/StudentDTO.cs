namespace ApiUniversity.Models;
public class StudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime EnrollmentDate { get; set; }

    //maj email
    public string Email { get; set; } = null!;
    
    public StudentDTO() { }
    // Constructeur à partir d'un Student
    public StudentDTO(Student student)
    {
        Id = student.Id;
        FirstName = student.FirstName;
        LastName = student.LastName;
        EnrollmentDate = student.EnrollmentDate;
        Email=student.Email;
    }

    
}