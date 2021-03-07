using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class RenameAssessmentTranslationToTranslationQuestionnaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Translations");

            migrationBuilder.CreateTable(
                name: "TranslationQuestionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    QuestionsJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslationQuestionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslationQuestionnaires_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 960, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 960, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 19, 52, 961, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "TranslationQuestionnaires",
                columns: new[] { "Id", "LanguageId", "QuestionsJson" },
                values: new object[,]
                {
                    { 1, 1, "[{}]" },
                    { 2, 2, "[{}]" },
                    { 3, 1, "[{}]" },
                    { 4, 2, "[{}]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TranslationQuestionnaires_LanguageId",
                table: "TranslationQuestionnaires",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TranslationQuestionnaires");

            migrationBuilder.CreateTable(
                name: "Translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    QuestionsJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Translations_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 184, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 6, 47, 185, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Translations",
                columns: new[] { "Id", "LanguageId", "QuestionsJson" },
                values: new object[,]
                {
                    { 3, 1, "[{}]" },
                    { 4, 2, "[{}]" },
                    { 1, 1, "[{}]" },
                    { 2, 2, "[{}]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Translations_LanguageId",
                table: "Translations",
                column: "LanguageId");
        }
    }
}
