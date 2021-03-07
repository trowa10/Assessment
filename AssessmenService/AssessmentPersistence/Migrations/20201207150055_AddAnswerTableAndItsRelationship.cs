using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddAnswerTableAndItsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 15, 0, 54, 649, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 51, 7, 871, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 637, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 637, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 637, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 637, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 637, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 0, 54, 638, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 51, 7, 871, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 15, 0, 54, 649, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 850, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 850, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 848, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 847, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 848, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 848, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 51, 7, 849, DateTimeKind.Utc) });
        }
    }
}
