using Microsoft.AspNetCore.Mvc;

namespace CustomRoutingApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Details(int id)
        {
            return Content("Employee ID: " + id);
        }
    }
}