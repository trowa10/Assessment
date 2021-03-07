using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class NewFormChangedFieldForAssessmentUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "formChanged",
                table: "AssessmentUserStatus",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "formChanged",
                table: "AssessmentUserStatus");

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
    }
}
