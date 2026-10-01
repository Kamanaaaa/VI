using EmployeeValidationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeValidationApp.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Employee information is valid and submitted successfully.";
            }

            return View(employee);
        }
    }
}