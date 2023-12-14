using System.ComponentModel.DataAnnotations;

namespace Paysky.Entities.Models.DataBase
{
    public class ArchivingVacancy
    {
        [Key]
        public int ArchivedVacancyId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public DateTime? PostedDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int MaxApplicant { get; set; }
        public int NoOfApplied { get; set; }
    }
}
