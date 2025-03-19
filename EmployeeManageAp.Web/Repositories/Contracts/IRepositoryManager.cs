

namespace EmployeeManageAp.Web.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IDepartmentRepository DepartmentRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }

        Task<int> SaveRepositoryAsync();
        int SaveRepository();
    }
}