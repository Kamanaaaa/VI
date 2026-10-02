using Microsoft.AspNetCore.Mvc;

namespace WebApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new[]
            {
                new { Id = 1, Name = "Kamana", Salary = 30000 },
                new { Id = 2, Name = "Sam", Salary = 35000 }
            };

            return Ok(employees);
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Salary { get; set; }
    }
}