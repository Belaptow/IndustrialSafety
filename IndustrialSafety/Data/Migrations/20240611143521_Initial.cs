using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "ChildEntitySequence");

            migrationBuilder.CreateSequence(
                name: "LegalEntitySequence");

            migrationBuilder.CreateSequence(
                name: "RecipientSequence");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DaysOfWeek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfWeek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceInits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViolationGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViolationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViolationGroupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                        column: x => x.ViolationGroupId,
                        principalTable: "ViolationGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [LegalEntitySequence]"),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCEO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCEA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NonResident = table.Column<bool>(type: "bit", nullable: false),
                    AverageRating = table.Column<double>(type: "float", nullable: false),
                    ProcurementRating = table.Column<double>(type: "float", nullable: false),
                    SupplyRating = table.Column<double>(type: "float", nullable: false),
                    EquipmentRating = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [LegalEntitySequence]"),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PSRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCEO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NCEA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NonResident = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitizenshipId = table.Column<int>(type: "int", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SexId = table.Column<int>(type: "int", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_People_Countries_CitizenshipId",
                        column: x => x.CitizenshipId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_Sexes_SexId",
                        column: x => x.SexId,
                        principalTable: "Sexes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ViolationKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViolationTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationKinds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                        column: x => x.ViolationTypeId,
                        principalTable: "ViolationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [LegalEntitySequence]"),
                    TIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LegalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TRRC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeadCompanyId = table.Column<int>(type: "int", nullable: true),
                    CEOId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessUnits_BusinessUnits_HeadCompanyId",
                        column: x => x.HeadCompanyId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BusinessUnits_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheckupNotififedBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupNotififedBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInitBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    PlaceInitId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceInitBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlaceInitBusinessUnits_PlaceInits_PlaceInitId",
                        column: x => x.PlaceInitId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CheckupTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "CheckupNotififedBusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckupKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupKinds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupKinds_CheckupTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CheckupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckupTypeNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    CheckupTypeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupTypeNotificationSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupTypeNotificationSettings_CheckupTypes_CheckupTypeId",
                        column: x => x.CheckupTypeId,
                        principalTable: "CheckupTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Checkups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    NumberOfViolations = table.Column<int>(type: "int", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitiatorId = table.Column<int>(type: "int", nullable: false),
                    AuditedBusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    AuditorId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                        column: x => x.AuditedBusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checkups_CheckupKinds_KindId",
                        column: x => x.KindId,
                        principalTable: "CheckupKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checkups_PlaceInits_InitiatorId",
                        column: x => x.InitiatorId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CheckupsDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupsDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [RecipientSequence]"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    HeadOfficeId = table.Column<int>(type: "int", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_Departments_HeadOfficeId",
                        column: x => x.HeadOfficeId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [RecipientSequence]"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    JobTitleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInitDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CheckupId = table.Column<int>(type: "int", nullable: true),
                    PlaceInitId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceInitDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceInitDepartments_Checkups_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "Checkups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlaceInitDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlaceInitDepartments_PlaceInits_PlaceInitId",
                        column: x => x.PlaceInitId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ViolationResponsibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [ChildEntitySequence]"),
                    ResponsibleId = table.Column<int>(type: "int", nullable: true),
                    CorrectionTerm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorrectionMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationResponsibles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViolationResponsibles_Employees_ResponsibleId",
                        column: x => x.ResponsibleId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    CheckupId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Violations_Checkups_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "Checkups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Violations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Violations_Employees_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Violations_ViolationKinds_KindId",
                        column: x => x.KindId,
                        principalTable: "ViolationKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "FullName", "Name" },
                values: new object[,]
                {
                    { 1, null, "Австралийский Союз", "Австралия" },
                    { 2, null, "Австрийская Республика", "Австрия" },
                    { 3, null, "Азербайджанская Республика", "Азербайджан" },
                    { 4, null, "Республика Албания", "Албания" },
                    { 5, null, "Алжирская Народная Демократическая Республика", "Алжир" },
                    { 6, null, "Республика Ангола", "Ангола" },
                    { 7, null, "Княжество Андорра", "Андорра" },
                    { 8, null, "Антигуа и Барбуда", "Антигуа и Барбуда" },
                    { 9, null, "Аргентинская Республика", "Аргентина" },
                    { 10, null, "Республика Армения", "Армения" },
                    { 11, null, "Исламский Эмират Афганистан", "Афганистан" },
                    { 12, null, "Содружество Багамских Островов", "Багамы" },
                    { 13, null, "Народная Республика Бангладеш", "Бангладеш" },
                    { 14, null, "Барбадос", "Барбадос" },
                    { 15, null, "Королевство Бахрейн", "Бахрейн" },
                    { 16, null, "Белиз", "Белиз" },
                    { 17, null, "Республика Беларусь", "Белоруссия" },
                    { 18, null, "Королевство Бельгия", "Бельгия" },
                    { 19, null, "Республика Бенин", "Бенин" },
                    { 20, null, "Республика Болгария", "Болгария" },
                    { 21, null, "Многонациональное Государство Боливия", "Боливия" },
                    { 22, null, "Босния и Герцеговина", "Босния и Герцеговина" },
                    { 23, null, "Республика Ботсвана", "Ботсвана" },
                    { 24, null, "Федеративная Республика Бразилия", "Бразилия" },
                    { 25, null, "Государство Бруней-Даруссалам", "Бруней" },
                    { 26, null, "Буркина-Фасо", "Буркина-Фасо" },
                    { 27, null, "Республика Бурунди", "Бурунди" },
                    { 28, null, "Королевство Бутан", "Бутан" },
                    { 29, null, "Республика Вануату", "Вануату" },
                    { 30, null, "Соединённое Королевство Великобритании и Северной Ирландии", "Великобритания" },
                    { 31, null, "Венгрия", "Венгрия" },
                    { 32, null, "Боливарианская Республика Венесуэла", "Венесуэла" },
                    { 33, null, "Демократическая Республика Восточный Тимор", "Восточный Тимор" },
                    { 34, null, "Социалистическая Республика Вьетнам", "Вьетнам" },
                    { 35, null, "Габонская Республика", "Габон" },
                    { 36, null, "Республика Гаити", "Гаити" },
                    { 37, null, "Кооперативная Республика Гайана", "Гайана" },
                    { 38, null, "Республика Гамбия", "Гамбия" },
                    { 39, null, "Республика Гана", "Гана" },
                    { 40, null, "Республика Гватемала", "Гватемала" },
                    { 41, null, "Гвинейская Республика", "Гвинея" },
                    { 42, null, "Республика Гвинея-Бисау", "Гвинея-Бисау" },
                    { 43, null, "Федеративная Республика Германия", "Германия" },
                    { 44, null, "Республика Гондурас", "Гондурас" },
                    { 45, null, "Гренада", "Гренада" },
                    { 46, null, "Греческая Республика", "Греция" },
                    { 47, null, "Грузия", "Грузия" },
                    { 48, null, "Королевство Дания", "Дания" },
                    { 49, null, "Республика Джибути", "Джибути" },
                    { 50, null, "Содружество Доминики", "Доминика" },
                    { 51, null, "Доминиканская Республика", "Доминикана" },
                    { 52, null, "Арабская Республика Египет", "Египет" },
                    { 53, null, "Республика Замбия", "Замбия" },
                    { 54, null, "Республика Зимбабве", "Зимбабве" },
                    { 55, null, "Государство Израиль", "Израиль" },
                    { 56, null, "Республика Индия", "Индия" },
                    { 57, null, "Республика Индонезия", "Индонезия" },
                    { 58, null, "Иорданское Хашимитское Королевство", "Иордания" },
                    { 59, null, "Республика Ирак", "Ирак" },
                    { 60, null, "Исламская Республика Иран", "Иран" },
                    { 61, null, "Республика Ирландия", "Ирландия" },
                    { 62, null, "Исландия", "Исландия" },
                    { 63, null, "Королевство Испания", "Испания" },
                    { 64, null, "Итальянская Республика", "Италия" },
                    { 65, null, "Йеменская Республика", "Йемен" },
                    { 66, null, "Республика Кабо-Верде", "Кабо-Верде" },
                    { 67, null, "Республика Казахстан", "Казахстан" },
                    { 68, null, "Королевство Камбоджа", "Камбоджа" },
                    { 69, null, "Республика Камерун", "Камерун" },
                    { 70, null, "Канада", "Канада" },
                    { 71, null, "Государство Катар", "Катар" },
                    { 72, null, "Республика Кения", "Кения" },
                    { 73, null, "Республика Кипр", "Кипр" },
                    { 74, null, "Республика Кирибати", "Кирибати" },
                    { 75, null, "Китайская Народная Республика", "Китай" },
                    { 76, null, "Республика Колумбия", "Колумбия" },
                    { 77, null, "Союз Коморских Островов", "Коморы" },
                    { 78, null, "Республика Конго", "Конго" },
                    { 79, null, "Демократическая Республика Конго", "ДР Конго" },
                    { 80, null, "Корейская Народно-Демократическая Республика", "КНДР" },
                    { 81, null, "Республика Корея", "Корея" },
                    { 82, null, "Республика Коста-Рика", "Коста-Рика" },
                    { 83, null, "Республика Кот-д’Ивуар", "Кот-д’Ивуар" },
                    { 84, null, "Республика Куба", "Куба" },
                    { 85, null, "Государство Кувейт", "Кувейт" },
                    { 86, null, "Кыргызская Республика", "Кыргызстан" },
                    { 87, null, "Лаосская Народно-Демократическая Республика", "Лаос" },
                    { 88, null, "Латвийская Республика", "Латвия" },
                    { 89, null, "Королевство Лесото", "Лесото" },
                    { 90, null, "Республика Либерия", "Либерия" },
                    { 91, null, "Ливанская Республика", "Ливан" },
                    { 92, null, "Государство Ливия", "Ливия" },
                    { 93, null, "Литовская Республика", "Литва" },
                    { 94, null, "Княжество Лихтенштейн", "Лихтенштейн" },
                    { 95, null, "Великое Герцогство Люксембург", "Люксембург" },
                    { 96, null, "Республика Маврикий", "Маврикий" },
                    { 97, null, "Исламская Республика Мавритания", "Мавритания" },
                    { 98, null, "Республика Мадагаскар", "Мадагаскар" },
                    { 99, null, "Республика Малави", "Малави" },
                    { 100, null, "Малайзия", "Малайзия" },
                    { 101, null, "Республика Мали", "Мали" },
                    { 102, null, "Мальдивская Республика", "Мальдивы" },
                    { 103, null, "Республика Мальта", "Мальта" },
                    { 104, null, "Королевство Марокко", "Марокко" },
                    { 105, null, "Республика Маршалловы Острова", "Маршалловы Острова" },
                    { 106, null, "Мексиканские Соединённые Штаты", "Мексика" },
                    { 107, null, "Федеративные Штаты Микронезии", "Микронезия" },
                    { 108, null, "Республика Мозамбик", "Мозамбик" },
                    { 109, null, "Республика Молдова", "Молдавия" },
                    { 110, null, "Княжество Монако", "Монако" },
                    { 111, null, "Монголия", "Монголия" },
                    { 112, null, "Республика Союз Мьянма", "Мьянма" },
                    { 113, null, "Республика Намибия", "Намибия" },
                    { 114, null, "Республика Науру", "Науру" },
                    { 115, null, "Федеративная Демократическая Республика Непал", "Непал" },
                    { 116, null, "Республика Нигер", "Нигер" },
                    { 117, null, "Федеративная Республика Нигерия", "Нигерия" },
                    { 118, null, "Королевство Нидерландов", "Нидерланды" },
                    { 119, null, "Республика Никарагуа", "Никарагуа" },
                    { 120, null, "Новая Зеландия", "Новая Зеландия" },
                    { 121, null, "Королевство Норвегия", "Норвегия" },
                    { 122, null, "Объединённые Арабские Эмираты", "ОАЭ" },
                    { 123, null, "Султанат Оман", "Оман" },
                    { 124, null, "Исламская Республика Пакистан", "Пакистан" },
                    { 125, null, "Республика Палау", "Палау" },
                    { 126, null, "Республика Панама", "Панама" },
                    { 127, null, "Независимое Государство Папуа&#160;— Новая Гвинея", "Папуа — Новая Гвинея" },
                    { 128, null, "Республика Парагвай", "Парагвай" },
                    { 129, null, "Республика Перу", "Перу" },
                    { 130, null, "Республика Польша", "Польша" },
                    { 131, null, "Португальская Республика", "Португалия" },
                    { 132, null, "Российская Федерация", "Россия" },
                    { 133, null, "Республика Руанда", "Руанда" },
                    { 134, null, "Румыния", "Румыния" },
                    { 135, null, "Республика Эль-Сальвадор", "Сальвадор" },
                    { 136, null, "Независимое Государство Самоа", "Самоа" },
                    { 137, null, "Республика Сан-Марино", "Сан-Марино" },
                    { 138, null, "Демократическая Республика Сан-Томе и Принсипи", "Сан-Томе и Принсипи" },
                    { 139, null, "Королевство Саудовская Аравия", "Саудовская Аравия" },
                    { 140, null, "Республика Северная Македония", "Северная Македония" },
                    { 141, null, "Республика Сейшельские Острова", "Сейшелы" },
                    { 142, null, "Республика Сенегал", "Сенегал" },
                    { 143, null, "Сент-Винсент и Гренадины", "Сент-Винсент и Гренадины" },
                    { 144, null, "Федерация Сент-Китс и Невис", "Сент-Китс и Невис" },
                    { 145, null, "Сент-Люсия", "Сент-Люсия" },
                    { 146, null, "Республика Сербия", "Сербия" },
                    { 147, null, "Республика Сингапур", "Сингапур" },
                    { 148, null, "Сирийская Арабская Республика", "Сирия" },
                    { 149, null, "Словацкая Республика", "Словакия" },
                    { 150, null, "Республика Словения", "Словения" },
                    { 151, null, "Соединённые Штаты Америки", "США" },
                    { 152, null, "Соломоновы Острова", "Соломоновы Острова" },
                    { 153, null, "Федеративная Республика Сомали", "Сомали" },
                    { 154, null, "Республика Судан", "Судан" },
                    { 155, null, "Республика Суринам", "Суринам" },
                    { 156, null, "Республика Сьерра-Леоне", "Сьерра-Леоне" },
                    { 157, null, "Республика Таджикистан", "Таджикистан" },
                    { 158, null, "Королевство Таиланд", "Таиланд" },
                    { 159, null, "Объединённая Республика Танзания", "Танзания" },
                    { 160, null, "Тоголезская Республика", "Того" },
                    { 161, null, "Королевство Тонга", "Тонга" },
                    { 162, null, "Республика Тринидад и Тобаго", "Тринидад и Тобаго" },
                    { 163, null, "Тувалу", "Тувалу" },
                    { 164, null, "Тунисская Республика", "Тунис" },
                    { 165, null, "Туркменистан", "Туркменистан" },
                    { 166, null, "Турецкая Республика", "Турция" },
                    { 167, null, "Республика Уганда", "Уганда" },
                    { 168, null, "Республика Узбекистан", "Узбекистан" },
                    { 169, null, "Украина", "Украина" },
                    { 170, null, "Восточная Республика Уругвай", "Уругвай" },
                    { 171, null, "Республика Фиджи", "Фиджи" },
                    { 172, null, "Республика Филиппины", "Филиппины" },
                    { 173, null, "Финляндская Республика", "Финляндия" },
                    { 174, null, "Французская Республика", "Франция" },
                    { 175, null, "Республика Хорватия", "Хорватия" },
                    { 176, null, "Центральноафриканская Республика", "ЦАР" },
                    { 177, null, "Республика Чад", "Чад" },
                    { 178, null, "Черногория", "Черногория" },
                    { 179, null, "Чешская Республика", "Чехия" },
                    { 180, null, "Республика Чили", "Чили" },
                    { 181, null, "Швейцарская Конфедерация", "Швейцария" },
                    { 182, null, "Королевство Швеция", "Швеция" },
                    { 183, null, "Демократическая Социалистическая Республика Шри-Ланка", "Шри-Ланка" },
                    { 184, null, "Республика Эквадор", "Эквадор" },
                    { 185, null, "Республика Экваториальная Гвинея", "Экваториальная Гвинея" },
                    { 186, null, "Государство Эритрея", "Эритрея" },
                    { 187, null, "Королевство Эсватини", "Эсватини" },
                    { 188, null, "Эстонская Республика", "Эстония" },
                    { 189, null, "Федеративная Демократическая Республика Эфиопия", "Эфиопия" },
                    { 190, null, "Южно-Африканская Республика", "ЮАР" },
                    { 191, null, "Республика Южный Судан", "Южный Судан" },
                    { 192, null, "Ямайка", "Ямайка" },
                    { 193, null, "Государство Япония", "Япония" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "79", 132, "Республика Адыгея" },
                    { 2, "84", 132, "Республика Алтай" },
                    { 3, "80", 132, "Республика Башкортостан" },
                    { 4, "81", 132, "Республика Бурятия" },
                    { 5, "82", 132, "Республика Дагестан" },
                    { 6, "21", 132, "Донецкая Народная Республика" },
                    { 7, "26", 132, "Республика Ингушетия" },
                    { 8, "83", 132, "Кабардино-Балкарская Республика" },
                    { 9, "85", 132, "Республика Калмыкия" },
                    { 10, "91", 132, "Карачаево-Черкесская Республика" },
                    { 11, "86", 132, "Республика Карелия" },
                    { 12, "87", 132, "Республика Коми" },
                    { 13, "43", 132, "Луганская Народная Республика" },
                    { 14, "88", 132, "Республика Марий Эл" },
                    { 15, "89", 132, "Республика Мордовия" },
                    { 16, "98", 132, "Республика Саха (Якутия)" },
                    { 17, "90", 132, "Республика Северная Осетия — Алания" },
                    { 18, "92", 132, "Республика Татарстан" },
                    { 19, "93", 132, "Республика Тыва" },
                    { 20, "94", 132, "Удмуртская Республика" },
                    { 21, "95", 132, "Республика Хакасия" },
                    { 22, "96", 132, "Чеченская Республика" },
                    { 23, "97", 132, "Чувашская Республика — Чувашия" },
                    { 24, "1", 132, "Алтайский край" },
                    { 25, "76", 132, "Забайкальский край" },
                    { 26, "30", 132, "Камчатский край" },
                    { 27, "3", 132, "Краснодарский край" },
                    { 28, "4", 132, "Красноярский край" },
                    { 29, "57", 132, "Пермский край" },
                    { 30, "5", 132, "Приморский край" },
                    { 31, "7", 132, "Ставропольский край" },
                    { 32, "8", 132, "Хабаровский край" },
                    { 33, "10", 132, "Амурская область" },
                    { 34, "12", 132, "Астраханская область" },
                    { 35, "14", 132, "Белгородская область" },
                    { 36, "15", 132, "Брянская область" },
                    { 37, "17", 132, "Владимирская область" },
                    { 38, "18", 132, "Волгоградская область" },
                    { 39, "19", 132, "Вологодская область" },
                    { 40, "20", 132, "Воронежская область" },
                    { 41, "23", 132, "Запорожская область" },
                    { 42, "24", 132, "Ивановская область" },
                    { 43, "25", 132, "Иркутская область" },
                    { 44, "27", 132, "Калининградская область" },
                    { 45, "29", 132, "Калужская область" },
                    { 46, "33", 132, "Кировская область" },
                    { 47, "34", 132, "Костромская область" },
                    { 48, "37", 132, "Курганская область" },
                    { 49, "38", 132, "Курская область" },
                    { 50, "41", 132, "Ленинградская область" },
                    { 51, "42", 132, "Липецкая область" },
                    { 52, "44", 132, "Магаданская область" },
                    { 53, "46", 132, "Московская область" },
                    { 54, "47", 132, "Мурманская область" },
                    { 55, "22", 132, "Нижегородская область" },
                    { 56, "49", 132, "Новгородская область" },
                    { 57, "50", 132, "Новосибирская область" },
                    { 58, "52", 132, "Омская область" },
                    { 59, "53", 132, "Оренбургская область" },
                    { 60, "54", 132, "Орловская область" },
                    { 61, "56", 132, "Пензенская область" },
                    { 62, "58", 132, "Псковская область" },
                    { 63, "60", 132, "Ростовская область" },
                    { 64, "61", 132, "Рязанская область" },
                    { 65, "36", 132, "Самарская область" },
                    { 66, "63", 132, "Саратовская область" },
                    { 67, "64", 132, "Сахалинская область" },
                    { 68, "65", 132, "Свердловская область" },
                    { 69, "66", 132, "Смоленская область" },
                    { 70, "68", 132, "Тамбовская область" },
                    { 71, "28", 132, "Тверская область" },
                    { 72, "69", 132, "Томская область" },
                    { 73, "70", 132, "Тульская область" },
                    { 74, "73", 132, "Ульяновская область" },
                    { 75, "74", 132, "Херсонская область" },
                    { 76, "75", 132, "Челябинская область" },
                    { 77, "78", 132, "Ярославская область" },
                    { 78, "45", 132, "Москва" },
                    { 79, "40", 132, "Санкт-Петербург" },
                    { 80, "99", 132, "Еврейская АО" },
                    { 81, "77", 132, "Чукотский АО" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CEOId",
                table: "BusinessUnits",
                column: "CEOId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_CityId",
                table: "BusinessUnits",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnits_HeadCompanyId",
                table: "BusinessUnits",
                column: "HeadCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupKinds_TypeId",
                table: "CheckupKinds",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupNotififedBusinessUnits_BusinessUnitId",
                table: "CheckupNotififedBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkups_AuditedBusinessUnitId",
                table: "Checkups",
                column: "AuditedBusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkups_AuditorId",
                table: "Checkups",
                column: "AuditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkups_InitiatorId",
                table: "Checkups",
                column: "InitiatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Checkups_KindId",
                table: "Checkups",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupsDepartments_DepartmentId",
                table: "CheckupsDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupTypeNotificationSettings_CheckupTypeId",
                table: "CheckupTypeNotificationSettings",
                column: "CheckupTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckupTypes_BusinessUnitId",
                table: "CheckupTypes",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CityId",
                table: "Companies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_GroupId",
                table: "DepartmentMembers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_MemberId",
                table: "DepartmentMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BusinessUnitId",
                table: "Departments",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_HeadOfficeId",
                table: "Departments",
                column: "HeadOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BusinessUnitId",
                table: "Employees",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobTitleId",
                table: "Employees",
                column: "JobTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PersonId",
                table: "Employees",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_UserId",
                table: "Employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CitizenshipId",
                table: "People",
                column: "CitizenshipId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CityId",
                table: "People",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_People_SexId",
                table: "People",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceInitBusinessUnits_BusinessUnitId",
                table: "PlaceInitBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceInitBusinessUnits_PlaceInitId",
                table: "PlaceInitBusinessUnits",
                column: "PlaceInitId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceInitDepartments_CheckupId",
                table: "PlaceInitDepartments",
                column: "CheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceInitDepartments_DepartmentId",
                table: "PlaceInitDepartments",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceInitDepartments_PlaceInitId",
                table: "PlaceInitDepartments",
                column: "PlaceInitId");

            migrationBuilder.CreateIndex(
                name: "IX_Regions_CountryId",
                table: "Regions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ViolationKinds_ViolationTypeId",
                table: "ViolationKinds",
                column: "ViolationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ViolationResponsibles_ResponsibleId",
                table: "ViolationResponsibles",
                column: "ResponsibleId");

            migrationBuilder.CreateIndex(
                name: "IX_Violations_AuthorId",
                table: "Violations",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Violations_CheckupId",
                table: "Violations",
                column: "CheckupId");

            migrationBuilder.CreateIndex(
                name: "IX_Violations_DepartmentId",
                table: "Violations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Violations_KindId",
                table: "Violations",
                column: "KindId");

            migrationBuilder.CreateIndex(
                name: "IX_ViolationTypes_ViolationGroupId",
                table: "ViolationTypes",
                column: "ViolationGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessUnits_Employees_CEOId",
                table: "BusinessUnits",
                column: "CEOId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_Employees_AuditorId",
                table: "Checkups",
                column: "AuditorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupsDepartments_Departments_DepartmentId",
                table: "CheckupsDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Cities_CityId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Cities_CityId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessUnits_Employees_CEOId",
                table: "BusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "CheckupsDepartments");

            migrationBuilder.DropTable(
                name: "CheckupTypeNotificationSettings");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "DaysOfWeek");

            migrationBuilder.DropTable(
                name: "DepartmentMembers");

            migrationBuilder.DropTable(
                name: "PlaceInitBusinessUnits");

            migrationBuilder.DropTable(
                name: "PlaceInitDepartments");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "ViolationResponsibles");

            migrationBuilder.DropTable(
                name: "Violations");

            migrationBuilder.DropTable(
                name: "Checkups");

            migrationBuilder.DropTable(
                name: "ViolationKinds");

            migrationBuilder.DropTable(
                name: "CheckupKinds");

            migrationBuilder.DropTable(
                name: "PlaceInits");

            migrationBuilder.DropTable(
                name: "ViolationTypes");

            migrationBuilder.DropTable(
                name: "CheckupTypes");

            migrationBuilder.DropTable(
                name: "ViolationGroups");

            migrationBuilder.DropTable(
                name: "CheckupNotififedBusinessUnits");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "BusinessUnits");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Sexes");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropSequence(
                name: "ChildEntitySequence");

            migrationBuilder.DropSequence(
                name: "LegalEntitySequence");

            migrationBuilder.DropSequence(
                name: "RecipientSequence");
        }
    }
}
