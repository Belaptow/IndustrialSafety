using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Company;
using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Parties;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace IndustrialSafety.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        #region Domain
        public DbSet<Entity> Entities { get; set; }
        #endregion
        #region Commons
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<LegalEntity> LegalEntities { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        #endregion

        #region Company
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        #endregion

        #region CoreEntities
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Group> Groups { get; set; }
        #endregion

        #region Parties
        public DbSet<Company> Companies { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<Person> People { get; set; }
        #endregion





        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Entity>().UseTpcMappingStrategy();
            builder.Entity<Recipient>().UseTpcMappingStrategy();
            builder.Entity<Group>().UseTpcMappingStrategy();
            builder.Entity<LegalEntity>().UseTpcMappingStrategy();

            builder.Entity<BusinessUnit>()
                .HasOne(unit => unit.CEO)
                .WithMany();

            builder.Entity<Employee>()
                .HasOne(emp => emp.BusinessUnit)
                .WithMany();

            builder.Entity<Department>()
                .HasOne(dept => dept.Manager)
                .WithMany();

            builder.Entity<Employee>()
                .HasOne(emp => emp.Department)
                .WithMany();

            

            base.OnModelCreating(builder);
        }

    }
}
