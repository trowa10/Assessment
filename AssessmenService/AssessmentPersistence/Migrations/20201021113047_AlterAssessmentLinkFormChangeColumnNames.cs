using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentLinkFormChangeColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ToAssessmentUserstatusId",
                table: "AssessmentLinkForms",
                newName: "LinkedAssessmentUserstatusId");

            migrationBuilder.RenameColumn(
                name: "FromAssessmentUserstatusId",
                table: "AssessmentLinkForms",
                newName: "AssessmentUserstatusId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 21, 11, 30, 46, 611, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 19, 10, 46, 43, 93, DateTimeKind.Utc));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LinkedAssessmentUserstatusId",
                table: "AssessmentLinkForms",
                newName: "ToAssessmentUserstatusId");

            migrationBuilder.RenameColumn(
                name: "AssessmentUserstatusId",
                table: "AssessmentLinkForms",
                newName: "FromAssessmentUserstatusId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 10, 19, 10, 46, 43, 93, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 10, 21, 11, 30, 46, 611, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 85, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 46, 43, 86, DateTimeKind.Utc) });
        }
    }
}
