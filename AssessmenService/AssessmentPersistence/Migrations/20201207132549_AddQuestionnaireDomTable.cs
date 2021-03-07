using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddQuestionnaireDomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 13, 25, 49, 50, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 12, 35, 39, 610, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "QuestionnaireDom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionnaireId = table.Column<int>(nullable: false),
                    DomId = table.Column<int>(nullable: false),
                    QuestionnaireDomOrder = table.Column<double>(nullable: false),
                    DateTimeUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireDom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionnaireDom_Dom_DomId",
                        column: x => x.DomId,
                        principalTable: "Dom",
                        principalColumn: "DomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionnaireDom_Questionnaire_QuestionnaireId",
                        column: x => x.QuestionnaireId,
                        principalTable: "Questionnaire",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 37, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 37, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 35, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 35, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 25, 49, 36, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireDom_DomId",
                table: "QuestionnaireDom",
                column: "DomId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireDom_QuestionnaireId",
                table: "QuestionnaireDom",
                column: "QuestionnaireId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionnaireDom");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 12, 35, 39, 610, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 13, 25, 49, 50, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 589, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 587, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 589, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 589, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 589, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 35, 39, 590, DateTimeKind.Utc) });
        }
    }
}
