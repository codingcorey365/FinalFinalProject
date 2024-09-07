using FinalFinalProject.Models;

namespace FinalFinalProject.Interfaces;

public interface IEmployeeRepository
{
    //public void CreateEmployee(int employeeID, string firstName, string lastName);
    public IEnumerable<Employee> GetAllEmployees();
    //public void UpdateEmployee(int productID, string updatedName);
    //public void DeleteEmployee(int productID);
}