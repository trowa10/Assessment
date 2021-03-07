using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddCategoryDomTranslationTableAndItsRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 41, 25, 604, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 34, 22, 771, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "CategoryDomTranslation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryDomId = table.Column<int>(nullable: false),
                    TranslationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDomTranslation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryDomTranslation_CategoryDom_CategoryDomId",
                        column: x => x.CategoryDomId,
                        principalTable: "CategoryDom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDomTranslation_Translation_TranslationId",
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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDomTranslation_CategoryDomId",
                table: "CategoryDomTranslation",
                column: "CategoryDomId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDomTranslation_TranslationId",
                table: "CategoryDomTranslation",
                column: "TranslationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDomTranslation");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 14, 34, 22, 771, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 14, 41, 25, 604, DateTimeKind.Utc));

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
        }
    }
}
