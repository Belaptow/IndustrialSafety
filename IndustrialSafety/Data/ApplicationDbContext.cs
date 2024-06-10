using IndustrialSafetyLib.Commons;
using IndustrialSafetyLib.Company;
using IndustrialSafetyLib.CoreEntities;
using IndustrialSafetyLib.Deals;
using IndustrialSafetyLib.Domain;
using IndustrialSafetyLib.Parties;
using IndustrialSafetyLib.ProductionSafety.Checkups;
using IndustrialSafetyLib.ProductionSafety.Settings;
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
        public DbSet<IndustrialSafetyLib.Commons.DayOfWeek> DaysOfWeek { get; set; }
        #endregion

        #region Company
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentMember> DepartmentMembers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        #endregion

        #region CoreEntities
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<ChildEntity> ChildEntities { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        #endregion

        #region Parties
        public DbSet<Company> Companies { get; set; }
        public DbSet<Counterparty> Counterparties { get; set; }
        public DbSet<Person> People { get; set; }
        #endregion

        #region Deals
        public DbSet<PlaceInit> PlaceInits { get; set; }
        public DbSet<PlaceInitDepartment> PlaceInitDepartments { get; set; }
        public DbSet<PlaceInitBusinessUnit> PlaceInitBusinessUnits { get; set; }
        #endregion

        #region ProductionSafety
        #region Checkups
        DbSet<Checkup> Checkups { get; set; }
        DbSet<CheckupDepartment> CheckupsDepartments { get; set; }
        DbSet<Violation> Violations { get; set; }
        DbSet<ViolationResponsible> ViolationResponsibles { get; set; }
        #endregion
        #region Settings
        DbSet<CheckupKind> CheckupKinds { get; set; }
        DbSet<CheckupType> CheckupTypes { get; set; }
        DbSet<CheckupNotififedBusinessUnit> CheckupNotififedBusinessUnits { get; set; }
        DbSet<CheckupTypeNotificationSetting> CheckupTypeNotificationSettings { get; set; }
        DbSet<ViolationGroup> ViolationGroups { get; set; }
        DbSet<ViolationKind> ViolationKinds { get; set; }
        DbSet<ViolationType> ViolationTypes { get; set; }
        #endregion
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
            builder.Entity<ChildEntity>().UseTpcMappingStrategy();

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
