using FinalFinalProject.Models;

namespace FinalFinalProject.Interfaces;

public interface IEmployeeRepository
{
    public void CreateEmployee(Employee employeeToInsert);
    public IEnumerable<Employee> GetAllEmployees();
    //public void UpdateEmployee(int productID, string updatedName);
    //public void DeleteEmployee(int productID);
    public Employee GetEmployeeById(int id);
}