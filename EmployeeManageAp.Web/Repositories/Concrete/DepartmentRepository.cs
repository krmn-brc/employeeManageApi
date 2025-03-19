
using EmployeeManageAp.Web.Entities.Models;
using EmployeeManageAp.Web.Repositories.Common;
using EmployeeManageAp.Web.Repositories.Contracts;

namespace EmployeeManageAp.Web.Repositories.Concrete
{
    public class DepartmentRepository:RepositoryBase<Department>, IDepartmentRepository
    {
        public DepartmentRepository(RepositoryContext context):base(context)
        {
            
        }
    }
}