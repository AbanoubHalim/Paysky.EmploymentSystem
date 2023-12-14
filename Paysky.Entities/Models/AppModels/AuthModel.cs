using System;
using System.Collections.Generic;

namespace Paysky.Entities.Models.AppModels
{
	public class AuthModel
	{
		public string Message { get; set; }
		public bool IsAuthenticated { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string? Role { get; set; }
		public string Token { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime ExpiresOn { get; set; }
	}
}