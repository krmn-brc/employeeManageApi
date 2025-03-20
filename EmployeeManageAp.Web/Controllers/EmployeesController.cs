using EmployeeManageAp.Web.Services.Contracts;
using EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManageAp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public EmployeesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employees = await _manager.EmployeeService.GetAllEmployees();
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee(EmployeeForInsertionDto employeeDto)
        {
            await _manager.EmployeeService.AddEmployeeAsync(employeeDto);
            return Ok();
        }
    }
}