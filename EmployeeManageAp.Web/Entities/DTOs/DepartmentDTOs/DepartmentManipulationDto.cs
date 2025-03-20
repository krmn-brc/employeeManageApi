using System.ComponentModel.DataAnnotations;
namespace EmployeeManageAp.Web.Entities.DTOs.DepartmentDTOs;

public abstract record DepartmentManipulationDto
{
    [Required(ErrorMessage="Department name is required")]
    [MinLength(2, ErrorMessage= "Department must consist of at least 2 characters")]
    public string Name { get; init; }
}