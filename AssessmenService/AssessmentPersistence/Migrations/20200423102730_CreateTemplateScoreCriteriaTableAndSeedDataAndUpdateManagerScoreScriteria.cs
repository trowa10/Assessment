using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class CreateTemplateScoreCriteriaTableAndSeedDataAndUpdateManagerScoreScriteria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScoreCriterias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreCriterias", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 5,
                column: "Max",
                value: 36);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 6,
                column: "Min",
                value: 37);

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "ScoreCriterias",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Employee" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScoreCriterias");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc), new DateTime(2020, 4, 23, 6, 55, 41, 802, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 5,
                column: "Max",
                value: 35);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 6,
                column: "Min",
                value: 36);

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
        }
    }
}
