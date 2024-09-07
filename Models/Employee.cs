namespace FinalFinalProject.Models;

public class Employee
{
    //EmployeeID
    public int EmployeeId { get; set; }

    //Name
    public string? EmployeeFirstName { get; set; }
    public string? EmployeeMiddleName { get; set; }
    public string? EmployeeLastName { get; set; }

    //Birthday
    public int EmployeeBirthMonth { get; set; }
    public int EmployeeBirthDay { get; set; }
    public int EmployeeBirthYear { get; set; }

    //Age
    public int EmployeeAge { get; set; }

    //Contact
    public int EmployeePhoneNumber { get; set; }
    public string? EmployeeEmailAddress { get; set; }
    public string? EmployeeHomeAddress { get; set; }

    //Current Position
    public string? EmployeeDepartment { get; set; }
    public int EmployeeTitle { get; set; }
    public int EmployeePayRate { get; set; }
    public int EmployeeHours { get; set; }
}