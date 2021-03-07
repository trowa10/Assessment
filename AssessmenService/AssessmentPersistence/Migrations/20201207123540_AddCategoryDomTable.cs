using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddCategoryDomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 12, 35, 39, 610, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 12, 22, 52, 865, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "DomElement",
                columns: table => new
                {
                    ElementId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomElement", x => x.ElementId);
                });

            migrationBuilder.CreateTable(
                name: "DomType",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomType", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Dom",
                columns: table => new
                {
                    DomId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ElementId = table.Column<int>(nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    DataType = table.Column<string>(nullable: true),
                    Id = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    IsRequired = table.Column<bool>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    PlaceHolder = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    DateTimeUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dom", x => x.DomId);
                    table.ForeignKey(
                        name: "FK_Dom_DomElement_ElementId",
                        column: x => x.ElementId,
                        principalTable: "DomElement",
                        principalColumn: "ElementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dom_DomType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "DomType",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryCode = table.Column<string>(nullable: true),
                    DomId = table.Column<int>(nullable: false),
                    CategoryDomOrder = table.Column<double>(nullable: false),
                    DateTimeUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryDom_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "CategoryCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryDom_Dom_DomId",
                        column: x => x.DomId,
                        principalTable: "Dom",
                        principalColumn: "DomId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDom_CategoryCode",
                table: "CategoryDom",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDom_DomId",
                table: "CategoryDom",
                column: "DomId");

            migrationBuilder.CreateIndex(
                name: "IX_Dom_ElementId",
                table: "Dom",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Dom_TypeId",
                table: "Dom",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryDom");

            migrationBuilder.DropTable(
                name: "Dom");

            migrationBuilder.DropTable(
                name: "DomElement");

            migrationBuilder.DropTable(
                name: "DomType");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 12, 22, 52, 865, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 12, 35, 39, 610, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 853, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 853, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc), new DateTime(2020, 12, 7, 12, 22, 52, 854, DateTimeKind.Utc) });
        }
    }
}
