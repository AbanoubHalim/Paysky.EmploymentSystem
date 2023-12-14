using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paysky.APIServices.Contract;
using Paysky.Entities.Models.AppModels;

namespace Paysky.EmploymentSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VacancyController : ControllerBase
	{
        private readonly IAuthService _authService;

        public VacancyController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Register(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }


        [HttpPost("login")]
        public async Task<IActionResult> GetTokenAsync([FromBody] LoginRequest model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _authService.Login(model);

            if (!result.IsAuthenticated)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}
