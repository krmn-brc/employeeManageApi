
using System.ComponentModel.DataAnnotations;

namespace EmployeeManageAp.Web.Entities.DTOs.DepartmentDTOs;

public record DepartmentForUpdateDto:DepartmentManipulationDto
{
    [Required]
    public int Id { get; init; }
}
