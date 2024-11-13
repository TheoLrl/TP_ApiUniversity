namespace ApiUniversity.Models;

public class Instructor
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public List<Course> Courses { get; set; }  // Un instructeur enseigne plusieurs cours
    public List<Department> AdministeredDepartments { get; set; }  // Un instructeur est associé à plusieurs départements
    public Instructor() { }
    public Instructor(InstructorDTO instructorDTO)
    {
        Id = instructorDTO.Id;
        FirstName = instructorDTO.FirstName;
        LastName = instructorDTO.LastName;
        HireDate = instructorDTO.HireDate;
    }
}
