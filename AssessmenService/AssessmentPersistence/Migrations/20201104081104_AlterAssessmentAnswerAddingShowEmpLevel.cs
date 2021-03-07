using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentAnswerAddingShowEmpLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 4, 8, 11, 4, 532, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 21, 11, 30, 46, 611, DateTimeKind.Utc));

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmpLevel",
                table: "AssessmentAnswers",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShowEmpLevel",
                table: "AssessmentAnswers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 21, 11, 30, 46, 611, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 4, 8, 11, 4, 532, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 593, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 591, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc), new DateTime(2020, 10, 21, 11, 30, 46, 592, DateTimeKind.Utc) });
        }
    }
}
