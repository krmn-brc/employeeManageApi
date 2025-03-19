
using EmployeeManageAp.Web.Services.Contracts;

namespace EmployeeManageAp.Web.Services.Concrete;

public class ServiceManager:IServiceManager
{
    private readonly IDepartmentService _departmentService;
    private readonly IEmployeeService _employeeService;
    public ServiceManager(IDepartmentService departmentService, IEmployeeService employeeService)
    {
        _departmentService = departmentService;
        _employeeService = employeeService;
    }

    public IDepartmentService DepartmentService => _departmentService;
    public IEmployeeService EmployeeService => _employeeService;
}
