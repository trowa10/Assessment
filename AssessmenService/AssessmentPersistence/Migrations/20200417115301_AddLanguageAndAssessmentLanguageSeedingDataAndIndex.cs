using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddLanguageAndAssessmentLanguageSeedingDataAndIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Code", "Description" },
                values: new object[,]
                {
                    { 1, "en", "English" },
                    { 2, "sv", "Swedish" }
                });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "AssessmentTemplateId", "LanguageId", "QuestionsJson" },
                values: new object[,]
                {
                    { 4, 2, 2, "[{}]" },
                    { 2, 1, 2, "[{}]" },
                    { 1, 1, 1, "[{}]" },
                    { 3, 2, 1, "[{}]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageId_AssessmentTemplateId",
                table: "Translations",
                columns: new[] { "LanguageId", "AssessmentTemplateId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Translations_LanguageId_AssessmentTemplateId",
                table: "Translations");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Translations",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
