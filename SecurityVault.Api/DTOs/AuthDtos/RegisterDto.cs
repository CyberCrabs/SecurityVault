using System.ComponentModel.DataAnnotations;

namespace SecurityVault.Api.Dtos.AuthDtos;

public class RegisterDto
{
    [Required] public string? Email { get; set; }
    [Required] public string? Username { get; set; }
    [Required] public string? Password { get; set; }
    [Required] public string? ConfirmPassword { get; set; }
}