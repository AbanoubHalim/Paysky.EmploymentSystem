using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paysky.Entities.Models.DataBase
{
    public class Employer 
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public string BackupPhoneNumber { get; set; }
		public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
		public virtual ICollection<Vacancy> Vacancies { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
