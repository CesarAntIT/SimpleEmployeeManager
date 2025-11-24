using EmployeeAPI.Data.Entities;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var empList = _service.Get().ToList();
            if (empList.Count() == 0)
            {
                return NoContent();
            }
            return Ok(empList);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee emp)
        {
            var newEmp = _service.Add(emp);
            if (newEmp == null)
                return BadRequest();
            return Ok(emp);
        }

        [HttpDelete]
        public IActionResult RemoveEmployee(Guid Id)
        {
            var result = _service.Remove(Id);
            if (!result)
                return NotFound();
            return Ok();
        }
    }
}
