using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddDateApprovedAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEmployeeApproved",
                table: "AssessmentAnswers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateManagerApproved",
                table: "AssessmentAnswers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateEmployeeApproved",
                table: "AssessmentAnswers");

            migrationBuilder.DropColumn(
                name: "DateManagerApproved",
                table: "AssessmentAnswers");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 327, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc) });
        }
    }
}
