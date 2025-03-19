
using EmployeeManageAp.Web.Entities.Models;
using EmployeeManageAp.Web.Repositories.Common;
using EmployeeManageAp.Web.Repositories.Contracts;

namespace EmployeeManageAp.Web.Repositories.Concrete
{
    public class EmployeeRepository:RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext context):base(context)
        {
            
        }
    }
}