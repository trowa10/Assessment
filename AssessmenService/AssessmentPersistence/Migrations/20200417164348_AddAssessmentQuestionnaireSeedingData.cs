using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddAssessmentQuestionnaireSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "AssessmentQuestionnaires",
                columns: new[] { "Id", "AssessmentTemplateId", "TranslationQuestionnaireId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 326, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 43, 48, 327, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AssessmentQuestionnaires",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestionnaires",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestionnaires",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AssessmentQuestionnaires",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 954, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 954, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });
        }
    }
}
