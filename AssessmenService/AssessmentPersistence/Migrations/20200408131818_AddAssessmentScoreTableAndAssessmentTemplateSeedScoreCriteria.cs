using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddAssessmentScoreTableAndAssessmentTemplateSeedScoreCriteria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 134, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 134, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScoreCriteriaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 2,
                column: "ScoreCriteriaId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScoreCriteriaId",
                value: 1);

            migrationBuilder.InsertData(
                table: "AssessmentScore",
                columns: new[] { "Id", "Max", "Min", "Name", "ScoreCriteriaId" },
                values: new object[,]
                {
                    { 4, 15, 0, "Developer", 2 },
                    { 5, 35, 16, "Performer", 2 },
                    { 6, 45, 36, "Outstanding", 2 }
                });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "ScoreCriteriaId" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 132, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "ScoreCriteriaId" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 18, 18, 133, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 59, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 1,
                column: "ScoreCriteriaId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 2,
                column: "ScoreCriteriaId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 3,
                column: "ScoreCriteriaId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "ScoreCriteriaId" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 57, DateTimeKind.Utc), 0 });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "ScoreCriteriaId" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 12, 59, 58, DateTimeKind.Utc), 0 });

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
    }
}
