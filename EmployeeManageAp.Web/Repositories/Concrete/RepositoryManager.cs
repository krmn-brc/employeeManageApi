
using EmployeeManageAp.Web.Repositories.Common;
using EmployeeManageAp.Web.Repositories.Contracts;

namespace EmployeeManageAp.Web.Repositories.Concrete
{
    public class RepositoryManager:IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IEmployeeRepository _employeeRepository;
        public RepositoryManager(RepositoryContext context,
         IDepartmentRepository departmentRepository,
         IEmployeeRepository employeeRepository)
        {
            _context = context;
            _departmentRepository = departmentRepository;
            _employeeRepository = employeeRepository;
        }

        public IDepartmentRepository DepartmentRepository => _departmentRepository;
        public IEmployeeRepository EmployeeRepository => _employeeRepository;

        public async Task<int> SaveRepositoryAsync() => await _context.SaveChangesAsync();
        public int SaveRepository() => _context.SaveChanges();
    }
}