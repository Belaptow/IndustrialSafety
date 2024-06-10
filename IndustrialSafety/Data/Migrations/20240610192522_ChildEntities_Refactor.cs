using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChildEntities_Refactor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DepartmentMembers_RootEntityId",
                table: "DepartmentMembers");

            migrationBuilder.DropColumn(
                name: "RootEntityId",
                table: "DepartmentMembers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RootEntityId",
                table: "DepartmentMembers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_RootEntityId",
                table: "DepartmentMembers",
                column: "RootEntityId");
        }
    }
}
