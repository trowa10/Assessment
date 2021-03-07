using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentUseStatusTableAddSiteCodeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteCode",
                table: "AssessmentUserStatus",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 119, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc), new DateTime(2020, 4, 21, 12, 1, 50, 120, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteCode",
                table: "AssessmentUserStatus");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 77, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 77, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 77, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 77, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 77, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc), new DateTime(2020, 4, 19, 6, 17, 9, 78, DateTimeKind.Utc) });
        }
    }
}
