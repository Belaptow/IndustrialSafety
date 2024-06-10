using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class NameGlobalization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ViolationResponsibles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PlaceInitDepartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PlaceInitBusinessUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "DepartmentMembers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CheckupTypeNotificationSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CheckupsDepartments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CheckupNotififedBusinessUnits",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "ViolationResponsibles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PlaceInitDepartments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PlaceInitBusinessUnits");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "DepartmentMembers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CheckupTypeNotificationSettings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CheckupsDepartments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CheckupNotififedBusinessUnits");
        }
    }
}
