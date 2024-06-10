using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class RequiredFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckupKinds_CheckupTypes_TypeId",
                table: "CheckupKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "CheckupNotififedBusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_CheckupKinds_KindId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_Employees_AuditorId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_PlaceInits_InitiatorId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupsDepartments_Departments_DepartmentId",
                table: "CheckupsDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                table: "CheckupTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_BusinessUnits_BusinessUnitId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BusinessUnits_BusinessUnitId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Countries_CitizenshipId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Sexes_SexId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "PlaceInitBusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceInitDepartments_Departments_DepartmentId",
                table: "PlaceInitDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Countries_CountryId",
                table: "Regions");

            migrationBuilder.DropForeignKey(
                name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                table: "ViolationKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Checkups_CheckupId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Departments_DepartmentId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Employees_AuthorId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_ViolationKinds_KindId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                table: "ViolationTypes");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Violations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Violations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BusinessUnitId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "DepartmentMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KindId",
                table: "Checkups",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupKinds_CheckupTypes_TypeId",
                table: "CheckupKinds",
                column: "TypeId",
                principalTable: "CheckupTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "CheckupNotififedBusinessUnits",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                table: "Checkups",
                column: "AuditedBusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_CheckupKinds_KindId",
                table: "Checkups",
                column: "KindId",
                principalTable: "CheckupKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_Employees_AuditorId",
                table: "Checkups",
                column: "AuditorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_PlaceInits_InitiatorId",
                table: "Checkups",
                column: "InitiatorId",
                principalTable: "PlaceInits",
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
                name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                table: "CheckupTypes",
                column: "BusinessUnitId",
                principalTable: "CheckupNotififedBusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_BusinessUnits_BusinessUnitId",
                table: "Departments",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BusinessUnits_BusinessUnitId",
                table: "Employees",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Countries_CitizenshipId",
                table: "People",
                column: "CitizenshipId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Sexes_SexId",
                table: "People",
                column: "SexId",
                principalTable: "Sexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "PlaceInitBusinessUnits",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceInitDepartments_Departments_DepartmentId",
                table: "PlaceInitDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Countries_CountryId",
                table: "Regions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                table: "ViolationKinds",
                column: "ViolationTypeId",
                principalTable: "ViolationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Checkups_CheckupId",
                table: "Violations",
                column: "CheckupId",
                principalTable: "Checkups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Departments_DepartmentId",
                table: "Violations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Employees_AuthorId",
                table: "Violations",
                column: "AuthorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_ViolationKinds_KindId",
                table: "Violations",
                column: "KindId",
                principalTable: "ViolationKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                table: "ViolationTypes",
                column: "ViolationGroupId",
                principalTable: "ViolationGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckupKinds_CheckupTypes_TypeId",
                table: "CheckupKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "CheckupNotififedBusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_CheckupKinds_KindId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_Employees_AuditorId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkups_PlaceInits_InitiatorId",
                table: "Checkups");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupsDepartments_Departments_DepartmentId",
                table: "CheckupsDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                table: "CheckupTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_BusinessUnits_BusinessUnitId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_BusinessUnits_BusinessUnitId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Countries_CitizenshipId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Sexes_SexId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "PlaceInitBusinessUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_PlaceInitDepartments_Departments_DepartmentId",
                table: "PlaceInitDepartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Countries_CountryId",
                table: "Regions");

            migrationBuilder.DropForeignKey(
                name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                table: "ViolationKinds");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Checkups_CheckupId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Departments_DepartmentId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_Employees_AuthorId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_Violations_ViolationKinds_KindId",
                table: "Violations");

            migrationBuilder.DropForeignKey(
                name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                table: "ViolationTypes");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Violations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Violations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BusinessUnitId",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "DepartmentMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KindId",
                table: "Checkups",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupKinds_CheckupTypes_TypeId",
                table: "CheckupKinds",
                column: "TypeId",
                principalTable: "CheckupTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "CheckupNotififedBusinessUnits",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                table: "Checkups",
                column: "AuditedBusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_CheckupKinds_KindId",
                table: "Checkups",
                column: "KindId",
                principalTable: "CheckupKinds",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_Employees_AuditorId",
                table: "Checkups",
                column: "AuditorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkups_PlaceInits_InitiatorId",
                table: "Checkups",
                column: "InitiatorId",
                principalTable: "PlaceInits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupsDepartments_Departments_DepartmentId",
                table: "CheckupsDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                table: "CheckupTypes",
                column: "BusinessUnitId",
                principalTable: "CheckupNotififedBusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_BusinessUnits_BusinessUnitId",
                table: "Departments",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_BusinessUnits_BusinessUnitId",
                table: "Employees",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_People_PersonId",
                table: "Employees",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Countries_CitizenshipId",
                table: "People",
                column: "CitizenshipId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Sexes_SexId",
                table: "People",
                column: "SexId",
                principalTable: "Sexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                table: "PlaceInitBusinessUnits",
                column: "BusinessUnitId",
                principalTable: "BusinessUnits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceInitDepartments_Departments_DepartmentId",
                table: "PlaceInitDepartments",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Countries_CountryId",
                table: "Regions",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                table: "ViolationKinds",
                column: "ViolationTypeId",
                principalTable: "ViolationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Checkups_CheckupId",
                table: "Violations",
                column: "CheckupId",
                principalTable: "Checkups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Departments_DepartmentId",
                table: "Violations",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_Employees_AuthorId",
                table: "Violations",
                column: "AuthorId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Violations_ViolationKinds_KindId",
                table: "Violations",
                column: "KindId",
                principalTable: "ViolationKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                table: "ViolationTypes",
                column: "ViolationGroupId",
                principalTable: "ViolationGroups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
