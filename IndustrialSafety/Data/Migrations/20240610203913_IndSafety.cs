using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IndustrialSafety.Data.Migrations
{
    /// <inheritdoc />
    public partial class IndSafety : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "DepartmentMembers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CheckupNotififedBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupNotififedBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupNotififedBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckupsDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupsDepartments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupsDepartments_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DaysOfWeek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysOfWeek", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceInits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViolationGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViolationResponsibles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    ResponsibleId = table.Column<int>(type: "int", nullable: true),
                    CorrectionTerm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorrectionMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verification = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "CheckupTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupTypes_CheckupNotififedBusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "CheckupNotififedBusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInitBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    PlaceInitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceInitBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceInitBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaceInitBusinessUnits_PlaceInits_PlaceInitId",
                        column: x => x.PlaceInitId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ViolationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViolationGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViolationTypes_ViolationGroups_ViolationGroupId",
                        column: x => x.ViolationGroupId,
                        principalTable: "ViolationGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckupKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckupKinds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckupKinds_CheckupTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "CheckupTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CheckupTypeNotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false),
                    CheckupTypeId = table.Column<int>(type: "int", nullable: true)
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
                name: "ViolationKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViolationTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViolationKinds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViolationKinds_ViolationTypes_ViolationTypeId",
                        column: x => x.ViolationTypeId,
                        principalTable: "ViolationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checkups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KindId = table.Column<int>(type: "int", nullable: true),
                    NumberOfViolations = table.Column<int>(type: "int", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InitiatorId = table.Column<int>(type: "int", nullable: false),
                    AuditedBusinessUnitId = table.Column<int>(type: "int", nullable: false),
                    AuditorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checkups_BusinessUnits_AuditedBusinessUnitId",
                        column: x => x.AuditedBusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkups_CheckupKinds_KindId",
                        column: x => x.KindId,
                        principalTable: "CheckupKinds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checkups_Employees_AuditorId",
                        column: x => x.AuditorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checkups_PlaceInits_InitiatorId",
                        column: x => x.InitiatorId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaceInitDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    CheckupId = table.Column<int>(type: "int", nullable: true),
                    PlaceInitId = table.Column<int>(type: "int", nullable: true)
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaceInitDepartments_PlaceInits_PlaceInitId",
                        column: x => x.PlaceInitId,
                        principalTable: "PlaceInits",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Violations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, defaultValueSql: "NEXT VALUE FOR [EntitySequence]"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KindId = table.Column<int>(type: "int", nullable: false),
                    CheckupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Violations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Violations_Checkups_CheckupId",
                        column: x => x.CheckupId,
                        principalTable: "Checkups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Violations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Violations_Employees_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Violations_ViolationKinds_KindId",
                        column: x => x.KindId,
                        principalTable: "ViolationKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckupsDepartments");

            migrationBuilder.DropTable(
                name: "CheckupTypeNotificationSettings");

            migrationBuilder.DropTable(
                name: "DaysOfWeek");

            migrationBuilder.DropTable(
                name: "PlaceInitBusinessUnits");

            migrationBuilder.DropTable(
                name: "PlaceInitDepartments");

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

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "DepartmentMembers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
