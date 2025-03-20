using AutoMapper;
using EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;
using EmployeeManageAp.Web.Entities.DTOs.DepartmentDTOs;
using EmployeeManageAp.Web.Entities.Models;
namespace EmployeeManageAp.Web.Infrastructure.AutoMapper;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<Department, DepartmentDto>();
        CreateMap<DepartmentForInsertionDto, Department>().ReverseMap();
        CreateMap<DepartmentForUpdateDto, Department>().ReverseMap();


        CreateMap<Employee, EmployeeDto>();
        CreateMap<EmployeeForInsertionDto, Employee>().ReverseMap();
        CreateMap<EmployeeForUpdateDto, Employee>().ReverseMap();
    }
}
