using System.ComponentModel.DataAnnotations;

namespace ToDosProject.Domain.DTOs;


public class LoginDTO
{
	[Required(ErrorMessage = "E-mail obrigat�rio!")]
	[EmailAddress(ErrorMessage = "O campo deve conter um {0} v�lido!")]
	public string? Email { get; set; }
	[Required(ErrorMessage = "Senha obrigat�ria!")]
	[DataType(DataType.Password)]
	public string? Password { get; set; }
	public string? TwoFactorCode { get; set; }
	public string? TwoFactorRecoveryCode { get; set; }
}

