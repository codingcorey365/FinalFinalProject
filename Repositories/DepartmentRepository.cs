using FinalFinalProject.Models;
using System.Data;
using Dapper;

namespace FinalFinalProject.Repositories;

public class DepartmentRepository
{
    private readonly IDbConnection _conn;

    public DepartmentRepository(IDbConnection conn)
    {
        _conn = conn;
    }
    public void CreateDepartment(string name)
    {
        _conn.Execute("INSERT INTO departments Name Values(@name);",
            new { name });
    }

    public IEnumerable<Department> GetDepartments()
    {
        return _conn.Query<Department>("Select * FROM departments;");
    }

    public void UpdateDepartment(int id, string newName)
    {
        _conn.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;", new { newName, id });
    }

    public void DeleteDepartment(Department department)
    {
        _conn.Execute("DELETE FROM departments WHERE DepartmentID = @departmentID;", new { department });
    }
}