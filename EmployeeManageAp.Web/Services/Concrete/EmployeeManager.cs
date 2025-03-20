
using AutoMapper;
using EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;
using EmployeeManageAp.Web.Entities.Models;
using EmployeeManageAp.Web.Repositories.Contracts;
using EmployeeManageAp.Web.Services.Contracts;

namespace EmployeeManageAp.Web.Services.Concrete;

public class EmployeeManager:IEmployeeService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    public EmployeeManager(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<List<EmployeeDto>> GetAllEmployees()
    {
        var values = await _repository.EmployeeRepository.FindAllAsync();
        var employees = _mapper.Map<List<EmployeeDto>>(values);
        return employees;
    }

    public async Task AddEmployeeAsync(EmployeeForInsertionDto employeeDto)
    {
        var employee = _mapper.Map<Employee>(employeeDto);
        employee.CreatedBy = "Admin Test";
        await _repository.EmployeeRepository.AddAsync(employee);
        await _repository.SaveRepositoryAsync();
    }
}
