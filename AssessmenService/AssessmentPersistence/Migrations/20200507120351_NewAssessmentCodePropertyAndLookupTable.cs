using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class NewAssessmentCodePropertyAndLookupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssessmentCode",
                table: "AssessmentTemplates",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentCode = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.UniqueConstraint("AK_Assessments_AssessmentCode", x => x.AssessmentCode);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 238, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 238, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 7,
                column: "ScoreCriteriaId",
                value: 1);

            migrationBuilder.InsertData(
                table: "AssessmentScore",
                columns: new[] { "Id", "Max", "Min", "Name", "ScoreCriteriaId" },
                values: new object[] { 8, -1, -1, "N/A", 2 });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "AssessmentCode", "Name" },
                values: new object[,]
                {
                    { 1, "PA2020", "Performance Appraisal 2020" },
                    { 2, "SD2020", "Salary Discussion 2020" }
                });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AssessmentCode", "DateCreated", "DateModified" },
                values: new object[] { "PA2020", new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 236, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AssessmentCode", "DateCreated", "DateModified" },
                values: new object[] { "SD2020", new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc), new DateTime(2020, 5, 7, 12, 3, 51, 237, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentTemplates_AssessmentCode",
                table: "AssessmentTemplates",
                column: "AssessmentCode");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentTemplates_Assessments_AssessmentCode",
                table: "AssessmentTemplates",
                column: "AssessmentCode",
                principalTable: "Assessments",
                principalColumn: "AssessmentCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentTemplates_Assessments_AssessmentCode",
                table: "AssessmentTemplates");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentTemplates_AssessmentCode",
                table: "AssessmentTemplates");

            migrationBuilder.DeleteData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "AssessmentCode",
                table: "AssessmentTemplates");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentScore",
                keyColumn: "Id",
                keyValue: 7,
                column: "ScoreCriteriaId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 301, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc), new DateTime(2020, 4, 23, 10, 27, 30, 302, DateTimeKind.Utc) });
        }
    }
}
