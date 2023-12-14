using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.AppModels
{
	public class VacancyDto
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string JobDescription { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; } = true;
        public string EmployerId { get; set; }

    }
}