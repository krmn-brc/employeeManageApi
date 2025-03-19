
using EmployeeManageAp.Web.Entities.Models.Common;

namespace EmployeeManageAp.Web.Entities.Models
{
    public class Department:EntityBase
    {
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}