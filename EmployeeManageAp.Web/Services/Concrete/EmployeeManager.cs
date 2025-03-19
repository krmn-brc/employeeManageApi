
using EmployeeManageAp.Web.Entities.Models;
using EmployeeManageAp.Web.Repositories.Contracts;
using EmployeeManageAp.Web.Services.Contracts;

namespace EmployeeManageAp.Web.Services.Concrete;

public class EmployeeManager:IEmployeeService
{
    private readonly IRepositoryManager _repository;
    public EmployeeManager(IRepositoryManager repository)
    {
        _repository = repository;
    }
    public async Task<List<Employee>> GetAllEmployees()
    {
        var employees = await _repository.EmployeeRepository.FindAllAsync();
        return employees;
    }
}
