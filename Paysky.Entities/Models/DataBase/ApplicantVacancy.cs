using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paysky.Entities.Models.DataBase
{
    public class ApplicantVacancy 
    {
        
        [ForeignKey("Vacancy")]
        public int VacancyId { get; set; }
        public Vacancy Vacancy { get; set; }


        [ForeignKey("Applicant")]
        public string ApplicantId { get; set; }
        public Applicant Applicant { get; set; }
        public DateTime? AppliedDate { get; set; }

    }
}
