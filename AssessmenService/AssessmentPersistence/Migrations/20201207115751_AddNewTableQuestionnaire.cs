using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddNewTableQuestionnaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 11, 57, 51, 215, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 10, 49, 59, 991, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "Questionnaire",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryCode = table.Column<string>(nullable: true),
                    QuestionCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaire", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 201, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 201, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 199, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc), new DateTime(2020, 12, 7, 11, 57, 51, 200, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_TemplateQuestionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire",
                column: "QuestionnaireId");

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateQuestionnaire_Questionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire",
                column: "QuestionnaireId",
                principalTable: "Questionnaire",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TemplateQuestionnaire_Questionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire");

            migrationBuilder.DropTable(
                name: "Questionnaire");

            migrationBuilder.DropIndex(
                name: "IX_TemplateQuestionnaire_QuestionnaireId",
                table: "TemplateQuestionnaire");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 10, 49, 59, 991, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 11, 57, 51, 215, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 962, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 961, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 962, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 962, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc), new DateTime(2020, 12, 7, 10, 49, 59, 963, DateTimeKind.Utc) });
        }
    }
}
