using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.AppModels
{
	public class LoginRequest
	{
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }
	}
}