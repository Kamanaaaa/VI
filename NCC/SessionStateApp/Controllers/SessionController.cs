using Microsoft.AspNetCore.Mvc;

namespace SessionStateApp.Controllers
{
    public class SessionController : Controller
    {
        // Page 1: Enter name
        public IActionResult Index()
        {
            return View();
        }

        // Store name in session
        [HttpPost]
        public IActionResult Save(string name)
        {
            HttpContext.Session.SetString("UserName", name);

            return RedirectToAction("Welcome");
        }

        // Page 2: Retrieve name
        public IActionResult Welcome()
        {
            string name = HttpContext.Session.GetString("UserName");

            ViewBag.UserName = name;

            return View();
        }
    }
}