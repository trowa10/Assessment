using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class addFkScoreToUserStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 775, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 773, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc), new DateTime(2020, 4, 8, 13, 24, 59, 774, DateTimeKind.Utc) });

            migrationBuilder.CreateIndex(
                name: "IX_AssessmentUserStatus_EmployeeLevelId",
                table: "AssessmentUserStatus",
                column: "EmployeeLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssessmentUserStatus_AssessmentScore_EmployeeLevelId",
                table: "AssessmentUserStatus",
                column: "EmployeeLevelId",
                principalTable: "AssessmentScore",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssessmentUserStatus_AssessmentScore_EmployeeLevelId",
                table: "AssessmentUserStatus");

            migrationBuilder.DropIndex(
                name: "IX_AssessmentUserStatus_EmployeeLevelId",
                table: "AssessmentUserStatus");


            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 201, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc), new DateTime(2020, 4, 7, 11, 25, 12, 202, DateTimeKind.Utc) });
        }
    }
}
