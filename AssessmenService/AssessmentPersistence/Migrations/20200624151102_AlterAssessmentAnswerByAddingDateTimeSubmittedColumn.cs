using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentAnswerByAddingDateTimeSubmittedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeSubmitted",
                table: "AssessmentAnswers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeSubmitted",
                table: "AssessmentAnswers");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 833, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 833, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 831, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 831, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 831, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 831, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc), new DateTime(2020, 6, 8, 12, 31, 1, 832, DateTimeKind.Utc) });
        }
    }
}
