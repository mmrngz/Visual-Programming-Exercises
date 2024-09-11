using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class returntable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageCount",
                table: "books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 3, 12, 40, 2, 364, DateTimeKind.Local).AddTicks(359), "$2a$11$jGQuPu9W/rMoo/zxzepNNeb8LolWPmNzOkOq69YLU.DPQeGqMSIE6" });

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 3, 12, 40, 2, 364, DateTimeKind.Local).AddTicks(6036), "$2a$11$z.0iNKLXLVuXIc4ZD1VnXutW6YAmNwr7qMCVv0vAYrh.jZ5FkoExG" });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 3, 12, 40, 2, 365, DateTimeKind.Local).AddTicks(4214));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PageCount",
                table: "books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 2, 11, 39, 22, 39, DateTimeKind.Local).AddTicks(9027), "$2a$11$uRNpCmy5zNelzpvjAkgV9udv5GEjrKl5yOSfTQhUGBf7IxhI.IDHm" });

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 2, 11, 39, 22, 40, DateTimeKind.Local).AddTicks(5477), "$2a$11$LEyRmbzy9dJu7CfMiQLsb.Kax25z6474/jRvfGul8sfp/CRLZvnd." });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5304));
        }
    }
}
