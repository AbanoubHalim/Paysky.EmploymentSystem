using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.DataBase
{
	public class ApplicationUser : IdentityUser
	{
		[Required, MaxLength(100)]
		public string FullName { get; set; }
	}
}