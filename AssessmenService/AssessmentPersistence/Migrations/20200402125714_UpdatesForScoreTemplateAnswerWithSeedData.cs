using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class UpdatesForScoreTemplateAnswerWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssessmentScore",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Min = table.Column<int>(nullable: false),
                    Max = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentScore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentTemplates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Version = table.Column<float>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    QuestionsJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentUserStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AssessmentTemplateId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    ReportsTo = table.Column<int>(nullable: false),
                    EmployeeLevelId = table.Column<int>(nullable: false),
                    UserRegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentUserStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentUserStatus_AssessmentTemplates_AssessmentTemplateId",
                        column: x => x.AssessmentTemplateId,
                        principalTable: "AssessmentTemplates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssessmentAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    AssessmentUserStatusId = table.Column<int>(nullable: false),
                    TotalScore = table.Column<int>(nullable: false),
                    AnswersJson = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssessmentAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssessmentAnswers_AssessmentUserStatus_AssessmentUserStatusId",
                        column: x => x.AssessmentUserStatusId,
                        principalTable: "AssessmentUserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssessmentScore",
                columns: new[] { "Id", "Max", "Min", "Name" },
                values: new object[,]
                {
                    { 1, 13, 0, "Developer" },
                    { 2, 31, 14, "Performer" },
                    { 3, 39, 32, "Outstanding" }
                });

            migrationBuilder.InsertData(
                table: "AssessmentTemplates",
                columns: new[] { "Id", "DateCreated", "DateModified", "EndDate", "IsActive", "ModifiedBy", "QuestionsJson", "StartDate", "Title", "Version", "Year" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 4, 2, 12, 57, 14, 485, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 485, DateTimeKind.Utc), new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10146063, "[{}]", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Performance Appraisal", 1f, 2020 },
                    { 2, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 10146063, "[{}]", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salary Discussion", 1f, 2020 }
                });

            migrationBuilder.InsertData(
                table: "AssessmentUserStatus",
                columns: new[] { "Id", "AssessmentTemplateId", "DateCreated", "DateModified", "EmployeeLevelId", "IsActive", "ModifiedBy", "ReportsTo", "StatusId", "UserId", "UserRegionId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999996, 2, 99999992, 1 },
                    { 2, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999995, 1, 99999991, 2 },
                    { 3, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 1111110, 1, 99999999, 1 },
                    { 4, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 2, 99999998, 1 },
                    { 5, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 1, 99999997, 2 },
                    { 6, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 0, 99999996, 1 },
                    { 7, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 1, 99999995, 2 },
                    { 8, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 2, 99999993, 1 },
                    { 9, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999999, 0, 99999994, 1 },
                    { 10, 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), 1, true, 10146063, 99999996, 1, 99999990, 2 }
                });

            migrationBuilder.InsertData(
                table: "AssessmentAnswers",
                columns: new[] { "Id", "AnswersJson", "AssessmentUserStatusId", "DateCreated", "DateModified", "IsActive", "ModifiedBy", "TotalScore" },
                values: new object[] { 1, "[{}]", 1, new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), new DateTime(2020, 4, 2, 12, 57, 14, 486, DateTimeKind.Utc), true, 10146063, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentAnswers_AssessmentUserStatusId",
                table: "AssessmentAnswers",
                column: "AssessmentUserStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentUserStatus_AssessmentTemplateId",
                table: "AssessmentUserStatus",
                column: "AssessmentTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssessmentAnswers");

            migrationBuilder.DropTable(
                name: "AssessmentScore");

            migrationBuilder.DropTable(
                name: "AssessmentUserStatus");

            migrationBuilder.DropTable(
                name: "AssessmentTemplates");
        }
    }
}
