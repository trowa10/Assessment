using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class RemoveAssessmentTeplateIdInAssessmentTranslation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Translations_LanguageId_AssessmentTemplateId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "AssessmentTemplateId",
                table: "Translations");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 461, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 460, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 461, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 461, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 5, 18, 462, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageId",
                table: "Translations",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Translations_LanguageId",
                table: "Translations");

            migrationBuilder.AddColumn<int>(
                name: "AssessmentTemplateId",
                table: "Translations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 739, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 738, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 739, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 739, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc), new DateTime(2020, 4, 17, 11, 53, 0, 740, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1,
                column: "AssessmentTemplateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2,
                column: "AssessmentTemplateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3,
                column: "AssessmentTemplateId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4,
                column: "AssessmentTemplateId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageId_AssessmentTemplateId",
                table: "Translations",
                columns: new[] { "LanguageId", "AssessmentTemplateId" });
        }
    }
}
