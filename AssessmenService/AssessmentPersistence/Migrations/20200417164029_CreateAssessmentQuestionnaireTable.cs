using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class CreateAssessmentQuestionnaireTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentQuestionnaires",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentTemplateId = table.Column<int>(nullable: false),
                    TranslationQuestionnaireId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentQuestionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestionnaires_AssessmentTemplates_AssessmentTempl~",
                        column: x => x.AssessmentTemplateId,
                        principalTable: "AssessmentTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssessmentQuestionnaires_TranslationQuestionnaires_Translati~",
                        column: x => x.TranslationQuestionnaireId,
                        principalTable: "TranslationQuestionnaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 954, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 954, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc), new DateTime(2020, 4, 17, 16, 40, 28, 955, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestionnaires_AssessmentTemplateId",
                table: "AssessmentQuestionnaires",
                column: "AssessmentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentQuestionnaires_TranslationQuestionnaireId",
                table: "AssessmentQuestionnaires",
                column: "TranslationQuestionnaireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentQuestionnaires");

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
        }
    }
}
