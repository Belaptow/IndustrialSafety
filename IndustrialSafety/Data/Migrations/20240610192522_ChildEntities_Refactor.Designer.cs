﻿// <auto-generated />
using System;
using IndustrialSafety.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240610192522_ChildEntities_Refactor")]
    partial class ChildEntities_Refactor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("EntitySequence");

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Domain.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [EntitySequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.City", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.Country", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.LegalEntity", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LegalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CityId");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.Region", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CountryId");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.Sex", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Sexes");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.JobTitle", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("JobTitles");
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.ChildEntity", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.Recipient", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Domain.Entity");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.BusinessUnit", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Commons.LegalEntity");

                    b.Property<int?>("CEOId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HeadCompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRRC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CEOId");

                    b.HasIndex("HeadCompanyId");

                    b.ToTable("BusinessUnits");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Parties.Counterparty", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Commons.LegalEntity");

                    b.Property<string>("NCEA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NCEO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NonResident")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PSRN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.GroupMember", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.CoreEntities.ChildEntity");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.HasIndex("GroupId");

                    b.HasIndex("MemberId");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.Employee", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.CoreEntities.Recipient");

                    b.Property<int?>("BusinessUnitId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("JobTitleId")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("JobTitleId");

                    b.HasIndex("ManagerId");

                    b.HasIndex("PersonId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.Group", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.CoreEntities.Recipient");

                    b.ToTable((string)null);
                });

            modelBuilder.Entity("IndustrialSafetyLib.Parties.Company", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Parties.Counterparty");

                    b.Property<double>("AverageRating")
                        .HasColumnType("float");

                    b.Property<double>("EquipmentRating")
                        .HasColumnType("float");

                    b.Property<double>("ProcurementRating")
                        .HasColumnType("float");

                    b.Property<double>("SupplyRating")
                        .HasColumnType("float");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Parties.Person", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.Parties.Counterparty");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CitizenshipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexId")
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CitizenshipId");

                    b.HasIndex("SexId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.DepartmentMember", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.CoreEntities.GroupMember");

                    b.ToTable("DepartmentMembers");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.Department", b =>
                {
                    b.HasBaseType("IndustrialSafetyLib.CoreEntities.Group");

                    b.Property<int>("BusinessUnitId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HeadOfficeId")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int");

                    b.HasIndex("BusinessUnitId");

                    b.HasIndex("HeadOfficeId");

                    b.HasIndex("ManagerId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("IndustrialSafetyLib.CoreEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("IndustrialSafetyLib.CoreEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndustrialSafetyLib.CoreEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("IndustrialSafetyLib.CoreEntities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.City", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Commons.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.LegalEntity", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Commons.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Commons.Region", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Commons.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.BusinessUnit", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Company.Employee", "CEO")
                        .WithMany()
                        .HasForeignKey("CEOId");

                    b.HasOne("IndustrialSafetyLib.Company.BusinessUnit", "HeadCompany")
                        .WithMany()
                        .HasForeignKey("HeadCompanyId");

                    b.Navigation("CEO");

                    b.Navigation("HeadCompany");
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.GroupMember", b =>
                {
                    b.HasOne("IndustrialSafetyLib.CoreEntities.Group", null)
                        .WithMany("Members")
                        .HasForeignKey("GroupId");

                    b.HasOne("IndustrialSafetyLib.CoreEntities.Recipient", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.Employee", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Company.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId");

                    b.HasOne("IndustrialSafetyLib.Company.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId");

                    b.HasOne("IndustrialSafetyLib.Company.JobTitle", "JobTitle")
                        .WithMany()
                        .HasForeignKey("JobTitleId");

                    b.HasOne("IndustrialSafetyLib.Company.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.HasOne("IndustrialSafetyLib.Parties.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndustrialSafetyLib.CoreEntities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("BusinessUnit");

                    b.Navigation("Department");

                    b.Navigation("JobTitle");

                    b.Navigation("Manager");

                    b.Navigation("Person");

                    b.Navigation("User");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Parties.Person", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Commons.Country", "Citizenship")
                        .WithMany()
                        .HasForeignKey("CitizenshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndustrialSafetyLib.Commons.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Citizenship");

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("IndustrialSafetyLib.Company.Department", b =>
                {
                    b.HasOne("IndustrialSafetyLib.Company.BusinessUnit", "BusinessUnit")
                        .WithMany()
                        .HasForeignKey("BusinessUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("IndustrialSafetyLib.Company.Department", "HeadOffice")
                        .WithMany()
                        .HasForeignKey("HeadOfficeId");

                    b.HasOne("IndustrialSafetyLib.Company.Employee", "Manager")
                        .WithMany()
                        .HasForeignKey("ManagerId");

                    b.Navigation("BusinessUnit");

                    b.Navigation("HeadOffice");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("IndustrialSafetyLib.CoreEntities.Group", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
