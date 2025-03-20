
namespace EmployeeManageAp.Web.Entities.Models.Common
{
    public class EntityBase:IEntityBase
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeletedBy { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }=false;
    }
}