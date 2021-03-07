using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentScoreTableAndAssessmentTemplateAddScoreCriteria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ScoreCriteriaId",
                table: "AssessmentTemplates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoreCriteriaId",
                table: "AssessmentScore",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 57, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScoreCriteriaId",
                table: "AssessmentTemplates");

            migrationBuilder.DropColumn(
                name: "ScoreCriteriaId",
                table: "AssessmentScore");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });
        }
    }
}
