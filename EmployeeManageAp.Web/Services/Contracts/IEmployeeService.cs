
using EmployeeManageAp.Web.Entities.Models;

namespace EmployeeManageAp.Web.Services.Contracts;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllEmployees();
}
