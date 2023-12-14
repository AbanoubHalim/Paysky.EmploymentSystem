using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.AppModels
{
	public class AddRoleModel
	{
		[Required]
		public string UserId { get; set; }

		[Required]
		public string Role { get; set; }
	}
}