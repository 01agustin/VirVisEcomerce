namespace VirVisEcomerce.Models;

using System.ComponentModel.DataAnnotations;

public class LoginViewModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Correo electrónico")]
    public string email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Contraseña")]
    public string password { get; set; }
}
