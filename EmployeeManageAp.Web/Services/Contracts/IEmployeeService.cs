
using EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;

namespace EmployeeManageAp.Web.Services.Contracts;

public interface IEmployeeService
{
    Task<List<EmployeeDto>> GetAllEmployees();
    Task AddEmployeeAsync(EmployeeForInsertionDto employeeDto);
}
