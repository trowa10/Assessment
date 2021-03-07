using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class NewTableAssessmentCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDoms_Categories_CategoryCode",
                table: "CategoryDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrders_Categories_CategoryCode",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropIndex(
                name: "IX_TemplateCategoryOrders_CategoryCode",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropIndex(
                name: "IX_CategoryDoms_CategoryCode",
                table: "CategoryDoms");

            migrationBuilder.DropColumn(
                name: "CategoryCode",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropColumn(
                name: "CategoryCode",
                table: "CategoryDoms");

            migrationBuilder.AddColumn<int>(
                name: "AssessmentCategoryId",
                table: "TemplateCategoryOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssessmentCategoryId",
                table: "CategoryDoms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 18, 13, 39, 58, 662, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 5, 15, 29, 28, 225, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "AssessmentCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentCategories_Categories_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Categories",
                        principalColumn: "CategoryCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 654, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 654, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc), new DateTime(2021, 1, 18, 13, 39, 58, 655, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryOrders_AssessmentCategoryId",
                table: "TemplateCategoryOrders",
                column: "AssessmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDoms_AssessmentCategoryId",
                table: "CategoryDoms",
                column: "AssessmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentCategories_CategoryCode",
                table: "AssessmentCategories",
                column: "CategoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDoms_AssessmentCategories_AssessmentCategoryId",
                table: "CategoryDoms",
                column: "AssessmentCategoryId",
                principalTable: "AssessmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrders_AssessmentCategories_AssessmentCatego~",
                table: "TemplateCategoryOrders",
                column: "AssessmentCategoryId",
                principalTable: "AssessmentCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryDoms_AssessmentCategories_AssessmentCategoryId",
                table: "CategoryDoms");

            migrationBuilder.DropForeignKey(
                name: "FK_TemplateCategoryOrders_AssessmentCategories_AssessmentCatego~",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropTable(
                name: "AssessmentCategories");

            migrationBuilder.DropIndex(
                name: "IX_TemplateCategoryOrders_AssessmentCategoryId",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropIndex(
                name: "IX_CategoryDoms_AssessmentCategoryId",
                table: "CategoryDoms");

            migrationBuilder.DropColumn(
                name: "AssessmentCategoryId",
                table: "TemplateCategoryOrders");

            migrationBuilder.DropColumn(
                name: "AssessmentCategoryId",
                table: "CategoryDoms");

            migrationBuilder.AddColumn<string>(
                name: "CategoryCode",
                table: "TemplateCategoryOrders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryCode",
                table: "CategoryDoms",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 5, 15, 29, 28, 225, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 18, 13, 39, 58, 662, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 216, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc), new DateTime(2021, 1, 5, 15, 29, 28, 217, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_TemplateCategoryOrders_CategoryCode",
                table: "TemplateCategoryOrders",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDoms_CategoryCode",
                table: "CategoryDoms",
                column: "CategoryCode");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryDoms_Categories_CategoryCode",
                table: "CategoryDoms",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TemplateCategoryOrders_Categories_CategoryCode",
                table: "TemplateCategoryOrders",
                column: "CategoryCode",
                principalTable: "Categories",
                principalColumn: "CategoryCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
