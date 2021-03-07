using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterDomTableAddColumnTableRowAndForAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ForAnswer",
                table: "Dom",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TableRow",
                table: "Dom",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 14, 12, 52, 14, 296, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 15, 30, 12, 293, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 287, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc), new DateTime(2020, 12, 14, 12, 52, 14, 288, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForAnswer",
                table: "Dom");

            migrationBuilder.DropColumn(
                name: "TableRow",
                table: "Dom");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 15, 30, 12, 293, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 14, 12, 52, 14, 296, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });
        }
    }
}
