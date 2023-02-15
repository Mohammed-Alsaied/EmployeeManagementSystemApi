using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Api.ViewModels.Authentication.Login;
public class LoginModel
{
    [Required(ErrorMessage = "User Name is required")]
    public string UserName { get; set; }
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; }
}