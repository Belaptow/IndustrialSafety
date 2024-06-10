using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChildEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    RootEntityId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentMembers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_GroupId",
                table: "DepartmentMembers",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_MemberId",
                table: "DepartmentMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentMembers_RootEntityId",
                table: "DepartmentMembers",
                column: "RootEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DepartmentMembers");
        }
    }
}
