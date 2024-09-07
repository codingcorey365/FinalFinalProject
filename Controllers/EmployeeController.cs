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
        ////Connection
        //private readonly IDbConnection _connection;

        //public EmployeeController(IDbConnection connection)
        //{
        //    _connection = connection;
        //}

        // Dependency Injection Employee Repository
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var employees = _repo.GetAllEmployees();
            return View(employees);
        }

        //[HttpGet("")]
        //public IActionResult Testing()
        //{
        //    var employees = _repo.GetAllEmployees();
        //    return View(employees);
        //}

        public IActionResult Update()
        {
            throw new NotImplementedException();
        }
        
        public IActionResult Update(Employee employee)
        {
            // todo: use repository to update employee
            //return RedirectToAction("Index");
            throw new NotImplementedException();
        }
    }
}
