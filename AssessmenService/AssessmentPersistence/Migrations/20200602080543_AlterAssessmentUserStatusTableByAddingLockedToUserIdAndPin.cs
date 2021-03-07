using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentUserStatusTableByAddingLockedToUserIdAndPin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LockedToUserId",
                table: "AssessmentUserStatus",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Pin",
                table: "AssessmentUserStatus",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 359, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 359, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 359, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 359, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 359, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc), new DateTime(2020, 6, 2, 8, 5, 43, 360, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LockedToUserId",
                table: "AssessmentUserStatus");

            migrationBuilder.DropColumn(
                name: "Pin",
                table: "AssessmentUserStatus");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 603, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 603, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 603, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 603, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc), new DateTime(2020, 5, 8, 8, 42, 36, 604, DateTimeKind.Utc) });
        }
    }
}
