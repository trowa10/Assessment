using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class ALterAnswerTableAddDateCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 15, 30, 12, 293, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 15, 6, 46, 717, DateTimeKind.Utc));

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentAnswerId = table.Column<int>(nullable: false),
                    DomId = table.Column<int>(nullable: false),
                    CategoryCode = table.Column<string>(nullable: true),
                    QuestionCode = table.Column<string>(nullable: true),
                    AnswerText = table.Column<string>(nullable: true),
                    Points = table.Column<int>(nullable: false),
                    DateTimeCreatedUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_AssessmentAnswers_AssessmentAnswerId",
                        column: x => x.AssessmentAnswerId,
                        principalTable: "AssessmentAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Answer_Category_CategoryCode",
                        column: x => x.CategoryCode,
                        principalTable: "Category",
                        principalColumn: "CategoryCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Answer_Dom_DomId",
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
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 274, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 30, 12, 275, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_AssessmentAnswerId",
                table: "Answer",
                column: "AssessmentAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_CategoryCode",
                table: "Answer",
                column: "CategoryCode");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_DomId",
                table: "Answer",
                column: "DomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 7, 15, 6, 46, 717, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 7, 15, 30, 12, 293, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 703, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 703, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 703, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 703, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 703, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc), new DateTime(2020, 12, 7, 15, 6, 46, 704, DateTimeKind.Utc) });
        }
    }
}
