
namespace EmployeeManageAp.Web.Services.Contracts;

public interface IServiceManager
{
    IDepartmentService DepartmentService { get; }
    IEmployeeService EmployeeService { get; }
}
