using Microsoft.AspNetCore.Mvc;

namespace FinalFinalProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void MethodName()
        {
            Console.WriteLine("this is a testmethod for the product controller using D.I.");
        }

    }

      

}
