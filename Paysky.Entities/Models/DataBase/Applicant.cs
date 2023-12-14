using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paysky.Entities.Models.DataBase
{
    public class Applicant 
    {
		[Key]
		[ForeignKey("ApplicationUser")]
		public string UserId { get; set; }
		public string? BackupPhoneNumber { get; set; }
		public string? CoverLetter { get; set; }
		public int Age { get; set; }
		public int? GraduationYear { get; set; }
		public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
		public virtual ApplicationUser ApplicationUser { get; set; }

	}
}
