
using EmployeeManageAp.Web.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManageAp.Web.Repositories.Configurations
{
    public class DepartmentConfig:IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
                new Department
                {
                    Id = 1,
                    Name = "Finance",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 25)
                },
                new Department
                {
                    Id = 2,
                    Name = "Development",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 25).AddMinutes(2.5)
                },
                new Department
                {
                    Id = 3,
                    Name = "IT",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 25).AddMinutes(4.90)
                }
            );
        }
    }
}