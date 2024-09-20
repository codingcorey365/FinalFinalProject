using System.Data;
using FinalFinalProject.Interfaces;
using FinalFinalProject.Models;
using FinalFinalProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalFinalProject.Controllers
{
    //[Route("Employee")]
    public class EmployeeController : Controller
    {
        // Dependency Injection Employee Repository
        private readonly IEmployeeRepository _repo;

        // Constructor to set the connection to private
        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        // Index
        public IActionResult Index()
        {
         
            return View();
        }

        // --- CRUD Application ---

        // --- Create ---
        
        // View Insert Employee
        public IActionResult InsertEmployee()
        {
            return View();
        }

        // Add Employee to Database
        public IActionResult InsertEmployeeToDatabase(Employee employeeToInsert)
        {
            _repo.CreateEmployee(employeeToInsert);

            return RedirectToAction("GetAllEmployees");
        }

        // --- Read ---

        // Get All Employees
        public IActionResult GetAllEmployees()
        {
            var employees = _repo.GetAllEmployees();
            return View(employees);
        }
        
        // View A Single Employee
        public IActionResult ViewSingleEmployee(int id)
        {
            var employee = _repo.GetEmployeeById(id);
            return View(employee);
        }

        // --- Update ---
        
        
        
        // --- Delete ---
    }
}
