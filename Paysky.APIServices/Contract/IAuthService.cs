using Paysky.Entities.Models.AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysky.APIServices.Contract
{
	public interface IAuthService
	{
		Task<AuthModel> Register(RegisterModel model);

		Task<AuthModel> Login(LoginRequest model);
	}
}
