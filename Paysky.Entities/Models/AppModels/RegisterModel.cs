using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.AppModels
{
	public class RegisterModel
	{
		[Required, StringLength(100)]
		public string FullName { get; set; }

		[Required, StringLength(50)]
		public string Username { get; set; }

		[Required, StringLength(100)]
		[EmailAddress]
		public string Email { get; set; }

		[Required, StringLength(50)]
		public string Password { get; set; }
		public string PhoneNumber { get; set; }
		public Role UserRole { get; set; }
	}
	public enum Role
	{
		Employer,
		Applicant,
	}
}