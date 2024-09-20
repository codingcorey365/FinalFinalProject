using Dapper;
using FinalFinalProject.Interfaces;
using FinalFinalProject.Models;
using System.Data;

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
    public void CreateEmployee(Employee employeeToInsert)
    {
         _connection.Execute("INSERT INTO employees (FirstName, MiddleName, LastName) VALUES (@FirstName, @MiddleName, @LastName);", new {   firstname = employeeToInsert.FirstName, middlename = employeeToInsert.MiddleName, lastname = employeeToInsert.LastName});
    }

    

    //public void DeleteEmployee(int productID)
    //{
    //    throw new NotImplementedException();
    //}

    public IEnumerable<Employee> GetAllEmployees()
    {
        return _connection.Query<Employee>("SELECT * FROM employees;");
    }
    public Employee GetEmployeeById(int id)
    {
        
        return _connection.QuerySingle<Employee>("SELECT * FROM employees where EmployeeId = @id", new { id =id });
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