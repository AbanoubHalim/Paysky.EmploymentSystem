using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Paysky.APIServices.Contract;
using Paysky.Entities.Constants;
using Paysky.Entities.Models.AppModels;
using Paysky.Entities.Models.DataBase;

namespace Paysky.EmploymentSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VacancyController : ControllerBase
	{
        private readonly IVacancyService _vacancyService;

        public VacancyController(IVacancyService vacancyService)
        {
            _vacancyService = vacancyService;
        }
        [HttpPost("create")]
        [Authorize(Roles = AppConstants.Employer)]
        public async Task<IActionResult> Create([FromBody] Vacancy model)
        {
            var employerId = HttpContext.Items["UserId"] as string;
            model.EmployeeId = employerId;

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _vacancyService.Create(model);

            return Ok(result);
        }


        [HttpPut("edit")]
        [Authorize(Roles = AppConstants.Employer)]
        public async Task EditVacancy(int vacancyId, VacancyDto vacancy)
        {
           await _vacancyService.EditVacancy(vacancyId, vacancy);
        }

		
	}
}
