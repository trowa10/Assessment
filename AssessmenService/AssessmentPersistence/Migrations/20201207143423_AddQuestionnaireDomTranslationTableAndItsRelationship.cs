using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddQuestionnaireDomTranslationTableAndItsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 34, 22, 771, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 13, 27, 10, 666, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "Translation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageCode = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionnaireDomTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionnaireDomId = table.Column<int>(nullable: false),
                    TranslationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionnaireDomTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionnaireDomTranslation_QuestionnaireDom_QuestionnaireDo~",
                        column: x => x.QuestionnaireDomId,
                        principalTable: "QuestionnaireDom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionnaireDomTranslation_Translation_TranslationId",
                        column: x => x.TranslationId,
                        principalTable: "Translation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 761, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc), new DateTime(2020, 12, 7, 14, 34, 22, 762, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireDomTranslation_QuestionnaireDomId",
                table: "QuestionnaireDomTranslation",
                column: "QuestionnaireDomId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionnaireDomTranslation_TranslationId",
                table: "QuestionnaireDomTranslation",
                column: "TranslationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionnaireDomTranslation");

            migrationBuilder.DropTable(
                name: "Translation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 13, 27, 10, 666, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 34, 22, 771, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 641, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 638, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 636, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 639, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 639, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 639, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc), new DateTime(2020, 12, 7, 13, 27, 10, 640, DateTimeKind.Utc) });
        }
    }
}
