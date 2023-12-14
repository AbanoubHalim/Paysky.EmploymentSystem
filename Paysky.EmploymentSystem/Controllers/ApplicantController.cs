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
    public class ApplicantController : ControllerBase
    {
        private readonly IVacancyService _vacancyService;

        public ApplicantController(IVacancyService vacancyService)
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

        [HttpDelete("remove")]
        [Authorize(Roles = AppConstants.Employer)]
        public async Task Remove(int vacancyId)
        {
            await _vacancyService.Delete(vacancyId);
        }

        [HttpGet("getAll")]
        [Authorize(Roles = AppConstants.Applicant)]
        [Authorize(Roles = AppConstants.Employer)]
        public async Task<IActionResult> GetAllVacancies()
        {
            return Ok(await _vacancyService.GetAllVacancies());
        }

        [HttpGet("getVacancy")]
        [Authorize(Roles = AppConstants.Applicant)]
        [Authorize(Roles = AppConstants.Employer)]
        public async Task<IActionResult> GetVacancy(int id)
        {
            return Ok(await _vacancyService.GetVacancy(id));
        }

    }
}
