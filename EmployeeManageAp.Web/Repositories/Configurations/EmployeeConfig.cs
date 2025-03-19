using EmployeeManageAp.Web.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManageAp.Web.Repositories.Configurations
{
    public class EmployeeConfig:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    DepartmentId = 1,
                    FirstName = "Engin",
                    LastName = "Demiroğ",
                    Email = "engindemrog@mail.com",
                    Phone = "212 435 45 23",
                    Gender = "Male",
                    Address = "Etimesgut/Ankara",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 13)
                },
                new Employee
                {
                    Id = 2,
                    DepartmentId = 2,
                    FirstName = "Gökhan",
                    LastName = "Kandemir",
                    Email = "gokhankandemir@mail.com",
                    Phone = "212 334 21 21",
                    Gender = "Male",
                    Address = "Bahçeşehir/İstanbul",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 13).AddMinutes(3.10)
                },
                new Employee
                {
                    Id = 3,
                    DepartmentId = 3,
                    FirstName = "Murat",
                    LastName = "Yücedağ",
                    Email = "muratyucedag@mail.com",
                    Phone = "212 663 43 87",
                    Gender = "Male",
                    Address = "Mecidiyeköy/İstanbul",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 13).AddMinutes(4.45)
                },
                new Employee
                {
                    Id = 4,
                    DepartmentId = 2,
                    FirstName = "Zafer",
                    LastName = "Cömert",
                    Email = "zafercomert@mail.com",
                    Phone = "212 776 55 42",
                    Gender = "Male",
                    Address = "Çarşamba/Samsun",
                    CreatedBy = "Admin Test",
                    CreatedDate = new DateTime(2025, 3, 13).AddMinutes(7.32)
                }
            );
        }
    }
}