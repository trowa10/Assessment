using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class CreateTableAssessmentFormTypeAndAlterAssessmentTemplateToAddColumnTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "AssessmentTemplates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AssessmentFormTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentFormTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentUserComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryCode = table.Column<string>(nullable: true),
                    AssessmentUserStatusId = table.Column<int>(nullable: false),
                    TwwId = table.Column<int>(nullable: false),
                    ParentId = table.Column<int>(nullable: false),
                    IsEdited = table.Column<bool>(nullable: false),
                    CreatedDateTime = table.Column<DateTime>(nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(nullable: false),
                    Comments = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentUserComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentUserComments_AssessmentUserStatus_AssessmentUserSt~",
                        column: x => x.AssessmentUserStatusId,
                        principalTable: "AssessmentUserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "AssessmentFormTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Performance Appraisal" },
                    { 2, "Salary Discussion" }
                });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "TypeId" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "TypeId" },
                values: new object[] { new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), new DateTime(2020, 10, 19, 10, 34, 52, 675, DateTimeKind.Utc), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentTemplates_TypeId",
                table: "AssessmentTemplates",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentUserComments_AssessmentUserStatusId",
                table: "AssessmentUserComments",
                column: "AssessmentUserStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentTemplates_AssessmentFormTypes_TypeId",
                table: "AssessmentTemplates",
                column: "TypeId",
                principalTable: "AssessmentFormTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentTemplates_AssessmentFormTypes_TypeId",
                table: "AssessmentTemplates");

            migrationBuilder.DropTable(
                name: "AssessmentFormTypes");

            migrationBuilder.DropTable(
                name: "AssessmentUserComments");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentTemplates_TypeId",
                table: "AssessmentTemplates");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "AssessmentTemplates");

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 297, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc), new DateTime(2020, 6, 24, 15, 11, 2, 298, DateTimeKind.Utc) });
        }
    }
}
