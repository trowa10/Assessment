using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddNewTableCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "Questionnaire",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 12, 10, 40, 959, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 11, 57, 51, 215, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryCode);
                });

            migrationBuilder.CreateTable(
                name: "TemplateCategoryOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentTemplateId = table.Column<int>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: true),
                    CategoryOrder = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateCategoryOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemplateCategoryOrder_AssessmentTemplates_AssessmentTemplate~",
                        column: x => x.AssessmentTemplateId,
                        principalTable: "AssessmentTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateCategoryOrder_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "CategoryCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 943, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 943, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 943, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 943, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 10, 40, 944, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaire_CategoryCode",
                table: "Questionnaire",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryOrder_AssessmentTemplateId",
                table: "TemplateCategoryOrder",
                column: "AssessmentTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryOrder_CategoryCode",
                table: "TemplateCategoryOrder",
                column: "CategoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaire_Category_CategoryCode",
                table: "Questionnaire",
                column: "CategoryCode",
                principalTable: "Category",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaire_Category_CategoryCode",
                table: "Questionnaire");

            migrationBuilder.DropTable(
                name: "TemplateCategoryOrder");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaire_CategoryCode",
                table: "Questionnaire");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryCode",
                table: "Questionnaire",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 11, 57, 51, 215, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 12, 10, 40, 959, DateTimeKind.Utc));

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
        }
    }
}
