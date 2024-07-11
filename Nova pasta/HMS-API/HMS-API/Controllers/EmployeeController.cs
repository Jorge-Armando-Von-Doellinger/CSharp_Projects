using HMS.Application.DTOs.Request.Employee;
using HMS.Application.Interfaces;
using HMS.Application.Models;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace HMS_API.Controllers
{
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeApplication _employeeApplication;
        public EmployeeController(IEmployeeApplication employeeApplication)
        {
            _employeeApplication = employeeApplication;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
            return Ok(await _employeeApplication.GetEmployeesAsync());
        }
        [HttpGet("{ID}")]
        public async Task<ActionResult> GetEmployeesById(Int64 ID)
        {
            return Ok(await _employeeApplication.GetEmployeeByIdAsync(ID));
        }
        [HttpGet("Find")]
        public async Task<ActionResult> GetEmployeesByCPF(Int64 CPF)
        {
            return Ok(await _employeeApplication.GetEmployeeByCPF(CPF));
        }
        [HttpGet("Find/ByName")]
        public async Task<ActionResult> GetEmployeesByName([FromQuery] string firstname, [FromQuery] string lastname)
        {
            return Ok(await _employeeApplication.GetEmployeeByName(firstname, lastname));
        }
        [HttpPost]
        public async Task<ActionResult<CreateEmployeeDTO>> CreateEmployee(CreateEmployeeDTO newEmployee)
        {
            return Ok(await _employeeApplication.CreateEmployeeAsync(newEmployee));
        }
        [HttpPut]
        public async Task<ActionResult<EmployeeUpdateDTO>> UpdateEmployee(EmployeeUpdateDTO editedEmployee)
        {
            return Ok(await _employeeApplication.UpdateEmployeeAsync(editedEmployee));
        }
        [HttpDelete]
        public async Task<ActionResult> DeleteEmployee([FromQuery]Int64 ID)
        {
            return Ok(await _employeeApplication.DeleteEmployeeAsync(ID));
        }
    }
}
