using FinalFinalProject.Models;
using System.Data;
using Dapper;
using FinalFinalProject.Interfaces;

namespace FinalFinalProject.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    // Create encapsulation
    // This is a field
    private readonly IDbConnection _connection;

    // Constructor
    // sets field to be a private value
    public EmployeeRepository(IDbConnection connection)
    {
        _connection = connection;
    }
    //public void CreateEmployee(int employeeID, string firstName, string lastName)
    //{
    //    _connection.Execute(
    //        "INSERT INTO employees (EmployeeID, FirstName, LastName) VALUES ('2', 'Tyson', 'Lind');");
    //}

    //public void DeleteEmployee(int productID)
    //{
    //    throw new NotImplementedException();
    //}

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _connection.Query<Employee>("SELECT * FROM employees;");
    }

    //public void UpdateEmployee(int productID, string updatedName)
    //{
    //    throw new NotImplementedException();
    //}

    //public void UpdateEmployeeName(int employeeId, string updatedName)
    //{
    //    _connection.Execute("Update employee set Name = @name where employeeId = @employeeId",
    //        new { name = updatedName, employeeId = employeeId });
    //}
}