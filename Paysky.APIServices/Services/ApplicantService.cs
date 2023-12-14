using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Paysky.APIServices.Contract;
using Paysky.Entities.Helpers;
using Paysky.Entities.Models.AppModels;
using Paysky.Entities.Models.DataBase;


namespace Paysky.APIServices.Services
{
	public class ApplicantService : IApplicantService
	{
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JWT _jwt;
        private readonly ApplicationDbContext _context;

        public ApplicantService(UserManager<ApplicationUser> userManager, IOptions<JWT> jwt, ApplicationDbContext context)
        {
            _userManager = userManager;
            _jwt = jwt.Value;
            _context = context;
        }

		public Task ArchiveVacancy(RegisterModel model)
		{
			throw new NotImplementedException();
		}

		public async Task<Vacancy> Create(Vacancy model)
		{
			try
			{
				var newVacancy= await _context.Vacancy.AddAsync(model);
				return newVacancy.Entity;
			}
			catch (Exception ex)
			{
				throw new Exception("Sorry error occured while insertion please try again",ex);
			}
		}

		public async Task Delete(int vacancyId)
		{
			var vacancy = await _context.Vacancy.FindAsync(vacancyId);
			
			if (vacancy == null)
				throw new Exception("Sorry Vacancy not found");

			_context.Vacancy.Remove(vacancy);
		}

		public async Task EditVacancy(int vacancyId, VacancyDto vacancy)
		{
			var vacancyDb = await _context.Vacancy.FindAsync(vacancyId);

			if (vacancyDb == null)
				throw new Exception("Sorry Vacancy not found");

			vacancyDb.ExpiryDate = vacancy.ExpiryDate;
			vacancyDb.PostedDate = vacancy.PostedDate;
			vacancyDb.JobDescription= vacancy.JobDescription;
			vacancyDb.JobTitle= vacancy.Title;
			vacancyDb.IsActive = vacancy.IsActive;

			_context.Vacancy.Update(vacancyDb);
		}

		public async Task<List<VacancyDto>> GetAllVacancies()
		{
			var vacancies = await _context.Vacancy.ToListAsync();
			var allVacancies = new List<VacancyDto>();
			foreach (var item in vacancies)
			{
				allVacancies.Add(Map(item));
			}
			return allVacancies;
		}

		public async Task<VacancyDto> GetVacancy(int id)
		{
			var vacancyDb = await _context.Vacancy.FindAsync(id);
			if(vacancyDb == null)
				throw new Exception("Sorry Vacancy not found");

			return Map(vacancyDb);
		}

		private static VacancyDto Map(Vacancy vacancy)
		{
			return new VacancyDto
			{
				Id = vacancy.Id,
				EmployerId = vacancy.EmployeeId,
				ExpiryDate = vacancy.ExpiryDate,
				IsActive = vacancy.IsActive,
				JobDescription = vacancy.JobDescription,
				PostedDate = vacancy.PostedDate,
				Title = vacancy.JobTitle
			};
		}
	}
}
