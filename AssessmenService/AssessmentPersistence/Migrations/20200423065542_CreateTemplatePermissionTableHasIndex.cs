using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class CreateTemplatePermissionTableHasIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemplatePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentTemplateId = table.Column<int>(nullable: false),
                    PermissionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplatePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplatePermissions_AssessmentTemplates_AssessmentTemplateId",
                        column: x => x.AssessmentTemplateId,
                        principalTable: "AssessmentTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 801, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 800, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 801, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 801, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_TemplatePermissions_AssessmentTemplateId",
                table: "TemplatePermissions",
                column: "AssessmentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplatePermissions_PermissionId",
                table: "TemplatePermissions",
                column: "PermissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplatePermissions");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 119, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });
        }
    }
}
