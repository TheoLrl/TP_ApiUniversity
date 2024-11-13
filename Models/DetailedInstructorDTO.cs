namespace ApiUniversity.Models;
public class DetailedInstructorDTO
{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime HireDate { get; set; }
    public List<Course> Courses { get; set; }  // Un instructeur enseigne plusieurs cours
    public List<Department> AdministeredDepartments { get; set; }  // Un instructeur est associé à plusieurs départements
    public DetailedInstructorDTO() { }
    public DetailedInstructorDTO(Instructor instructor)
    {
        Id = instructor.Id;
        FirstName = instructor.FirstName;
        LastName = instructor.LastName;
        HireDate = instructor.HireDate;
        Courses = instructor.Courses;
        AdministeredDepartments = instructor.AdministeredDepartments;
    }
}