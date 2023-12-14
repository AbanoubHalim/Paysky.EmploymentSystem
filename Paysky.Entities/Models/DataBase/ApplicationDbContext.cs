using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Paysky.Entities.Models.DataBase;

namespace Paysky.Entities.Models.DataBase
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
        public virtual DbSet<Applicant> Applicant { get; set; }
        public virtual DbSet<Employer> Employer { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }
        public virtual DbSet<ApplicantVacancy> ApplicantVacancies { get; set; }
        public virtual DbSet<ArchivingVacancy> ArchivingVacancy { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Vacancy>()
                .HasOne<Employer>(e => e.Employer)
                .WithMany(v => v.Vacancies)
                .HasForeignKey(e => e.EmployeeId);

            modelBuilder.Entity<ApplicantVacancy>()
                .HasKey(av => new { av.ApplicantId, av.VacancyId });

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }
        }
    }
}