using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManageAp.Web.Services.Contracts;
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
    }
}