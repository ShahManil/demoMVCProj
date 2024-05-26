using Microsoft.AspNetCore.Mvc;
using demoMVCProj.Models;

namespace demoMVCProj.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(EmployeeModel e)
        {
            ViewData["name"] = e.FirstName;
            ViewData["surname"] = e.LastName;
            Console.WriteLine("Name  : " + e.FirstName + " " + e.LastName + "\nAge : " + e.Age + "\nGender : " + e.Gender + "\nMarital Status : " + e.Status + "\nDescription : " + e.Description);
            return View("RegisterConfirmation");
            //return View ("~/Views/Home/Index.cshtml");
        }
    }
}
