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
using System.Reflection.Emit;
using SharedLib;
using Microsoft.Build.Execution;
using IndustrialSafetyDataSeed.DTO.Commons;
using IndustrialSafetyDataSeed;


namespace IndustrialSafety.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        #region Domain
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
        public DbSet<Checkup> Checkups { get; set; }
        public DbSet<CheckupDepartment> CheckupsDepartments { get; set; }
        public DbSet<Violation> Violations { get; set; }
        public DbSet<ViolationResponsible> ViolationResponsibles { get; set; }
        #endregion
        #region Settings
        public DbSet<CheckupKind> CheckupKinds { get; set; }
        public DbSet<CheckupType> CheckupTypes { get; set; }
        public DbSet<CheckupNotififedBusinessUnit> CheckupNotififedBusinessUnits { get; set; }
        public DbSet<CheckupTypeNotificationSetting> CheckupTypeNotificationSettings { get; set; }
        public DbSet<ViolationGroup> ViolationGroups { get; set; }
        public DbSet<ViolationKind> ViolationKinds { get; set; }
        public DbSet<ViolationType> ViolationTypes { get; set; }
        #endregion
        #endregion

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Recipient>().UseTpcMappingStrategy();
            builder.Entity<Group>().UseTpcMappingStrategy();
            builder.Entity<LegalEntity>().UseTpcMappingStrategy();
            builder.Entity<ChildEntity>().UseTpcMappingStrategy();

            builder.Model.GetEntityTypes()
                         .SelectMany(t => t.GetForeignKeys())
                         .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade)
                         .ForEach(fk => fk.DeleteBehavior = DeleteBehavior.Restrict);

            var countries = DataSeedService.GetAll<CountryDTO>().Select((dto, index) => new Country() { FullName = dto.FullName, Id = index + 1, Name = dto.Name });
            var regions = DataSeedService.GetAll<RegionDTO>().Select((dto, index) => new { Id = index + 1, Name = dto.Name, Code = dto.Code, CountryId = countries.Single(country => Equals(country.Name, dto.Country)).Id });

            builder.Entity<Country>()
                .HasData(countries);

            builder.Entity<Region>()
                .HasData(regions);

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
