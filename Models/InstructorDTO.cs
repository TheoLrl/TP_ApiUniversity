namespace ApiUniversity.Models;
public class InstructorDTO{

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public  DateTime HireDate{get;set;}
    public List<Course> Courses { get; set; }  // Un instructeur enseigne plusieurs cours
    public List<Department> AdministeredDepartments { get; set; }  // Un instructeur est associé à plusieurs départements
    public InstructorDTO() {}
     public InstructorDTO(Instructor instructor) {
        Id = instructor.Id;
        FirstName= instructor.FirstName;
        LastName = instructor.LastName;
        HireDate= instructor.HireDate;
     }
}