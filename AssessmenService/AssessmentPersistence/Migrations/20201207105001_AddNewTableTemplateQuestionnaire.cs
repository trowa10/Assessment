using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddNewTableTemplateQuestionnaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 10, 49, 59, 991, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 11, 23, 13, 30, 26, 369, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "TemplateQuestionnaire",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentTemplateId = table.Column<int>(nullable: false),
                    QuestionnaireId = table.Column<int>(nullable: false),
                    Questionnairorder = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateQuestionnaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateQuestionnaire_AssessmentTemplates_AssessmentTemplate~",
                        column: x => x.AssessmentTemplateId,
                        principalTable: "AssessmentTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TemplateQuestionnaire_AssessmentTemplateId",
                table: "TemplateQuestionnaire",
                column: "AssessmentTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemplateQuestionnaire");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 23, 13, 30, 26, 369, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 10, 49, 59, 991, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 346, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc), new DateTime(2020, 11, 23, 13, 30, 26, 347, DateTimeKind.Utc) });
        }
    }
}
