using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentAnswerAddApproverTwwIdField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApproverTwwId",
                table: "AssessmentAnswers",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApproverTwwId",
                table: "AssessmentAnswers");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 681, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 681, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc), new DateTime(2020, 6, 2, 14, 1, 11, 682, DateTimeKind.Utc) });
        }
    }
}
