
using EmployeeManageAp.Web.Entities.Models.Common;

namespace EmployeeManageAp.Web.Entities.Models
{
    public class Employee:EntityBase
    {
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        public Department Department { get; set; }
    }
}