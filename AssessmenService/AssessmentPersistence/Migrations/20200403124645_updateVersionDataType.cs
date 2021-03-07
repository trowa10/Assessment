using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class updateVersionDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Version",
                table: "AssessmentTemplates",
                nullable: true,
                oldClrType: typeof(float));

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
                columns: new[] { "DateCreated", "DateModified", "Version" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 327, DateTimeKind.Utc), "1.0" });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Version" },
                values: new object[] { new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), new DateTime(2020, 4, 3, 12, 46, 45, 328, DateTimeKind.Utc), "1.0" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Version",
                table: "AssessmentTemplates",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Version" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 485, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 485, DateTimeKind.Utc), 1f });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Version" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1f });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc) });
        }
    }
}
