﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssessmentPersistence.Migrations
{
    public partial class AddFKDomIdInCategoryDom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 4, 14, 21, 48, 630, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 12, 15, 10, 12, 23, 899, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 623, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 623, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc), new DateTime(2021, 1, 4, 14, 21, 48, 622, DateTimeKind.Utc) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AssessmentLinkForms",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 15, 10, 12, 23, 899, DateTimeKind.Utc),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 1, 4, 14, 21, 48, 630, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "AssessmentAnswers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 890, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentTemplates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "AssessmentUserStatus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc), new DateTime(2020, 12, 15, 10, 12, 23, 891, DateTimeKind.Utc) });
        }
    }
}
