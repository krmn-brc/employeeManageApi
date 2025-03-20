using System.ComponentModel.DataAnnotations;
namespace EmployeeManageAp.Web.Entities.DTOs.EmployeeDTOs;

public abstract record EmployeeManipulationDto
{
    [Required(ErrorMessage = "Department is required")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; }

    [Required(ErrorMessage="Phone is required")]
    public string Phone { get; set; }

    [Required(ErrorMessage="Address is required")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; }
}
