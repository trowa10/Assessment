using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterTemplateQuestionnaireFixColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Questionnairorder",
                table: "TemplateQuestionnaire",
                newName: "QuestionnaireOrder");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 15, 10, 2, 6, 366, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 14, 12, 52, 14, 296, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 358, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 356, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 2, 6, 357, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionnaireOrder",
                table: "TemplateQuestionnaire",
                newName: "Questionnairorder");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 14, 12, 52, 14, 296, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 15, 10, 2, 6, 366, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });
        }
    }
}
