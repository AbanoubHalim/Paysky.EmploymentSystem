using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paysky.Entities.Models.DataBase
{
    public class Vacancy
    {
        [Key]
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int MaxApplicant { get; set; }
        public bool IsArchived { get; set; }
        public int NoOfApplied { get; set; }
        public virtual Employer Employer { get; set; }
        public string EmployeeId { get; set; }
    }
}
