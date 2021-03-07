using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentTemplateTableAddIsStashColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isStash",
                table: "AssessmentTemplates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 23, 13, 30, 26, 369, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 4, 8, 11, 4, 532, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 346, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isStash",
                table: "AssessmentTemplates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 4, 8, 11, 4, 532, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 23, 13, 30, 26, 369, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 521, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 521, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc), new DateTime(2020, 11, 4, 8, 11, 4, 522, DateTimeKind.Utc) });
        }
    }
}
