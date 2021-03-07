using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AlterAssessmentTemplatetoAddAssessmentTemplateRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssessmentTemplateId",
                table: "AssessmentTemplates",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 51, 7, 871, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 41, 25, 604, DateTimeKind.Utc));

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

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentTemplates_AssessmentTemplateId",
                table: "AssessmentTemplates",
                column: "AssessmentTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentTemplates_AssessmentTemplates_AssessmentTemplateId",
                table: "AssessmentTemplates",
                column: "AssessmentTemplateId",
                principalTable: "AssessmentTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentTemplates_AssessmentTemplates_AssessmentTemplateId",
                table: "AssessmentTemplates");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentTemplates_AssessmentTemplateId",
                table: "AssessmentTemplates");

            migrationBuilder.DropColumn(
                name: "AssessmentTemplateId",
                table: "AssessmentTemplates");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 41, 25, 604, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 51, 7, 871, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 594, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 594, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 594, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 594, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 594, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 41, 25, 595, DateTimeKind.Utc) });
        }
    }
}
