using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class CreateTableAssessmentLinkForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "AssessmentUserComments",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "AssessmentLinkForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FromAssessmentUserstatusId = table.Column<int>(nullable: false),
                    ToAssessmentUserstatusId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2020, 10, 19, 10, 46, 43, 93, DateTimeKind.Utc))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentLinkForms", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentLinkForms");

            migrationBuilder.AlterColumn<int>(
                name: "ParentId",
                table: "AssessmentUserComments",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });
        }
    }
}
