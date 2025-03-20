using System.ComponentModel.DataAnnotations;

namespace EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;

public record EmployeeForUpdateDto:EmployeeManipulationDto
{
    [Required(ErrorMessage="Id is required")]
    public int Id { get; set; }
}
