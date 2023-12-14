using Paysky.Entities.Models.AppModels;
using Paysky.Entities.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysky.APIServices.Contract
{
	public interface IVacancyService
	{
		Task<Vacancy> Create(Vacancy model);
		Task EditVacancy(int vacancyId, VacancyDto vacancy);
		Task Delete(int vacancyId);
		Task<List<VacancyDto>> GetAllVacancies();
		Task<VacancyDto> GetVacancy(int id);
		Task ArchiveVacancy(RegisterModel model);

	}
}
