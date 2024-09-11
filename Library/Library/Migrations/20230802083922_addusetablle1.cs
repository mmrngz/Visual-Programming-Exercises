using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class addusetablle1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "ID", "DateTime", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 2, 11, 39, 22, 39, DateTimeKind.Local).AddTicks(9027), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$uRNpCmy5zNelzpvjAkgV9udv5GEjrKl5yOSfTQhUGBf7IxhI.IDHm", 1, 1, "Muhammet" },
                    { 2, new DateTime(2023, 8, 2, 11, 39, 22, 40, DateTimeKind.Local).AddTicks(5477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$LEyRmbzy9dJu7CfMiQLsb.Kax25z6474/jRvfGul8sfp/CRLZvnd.", 2, 1, "Duhan" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "DateTime", "FirstName", "LastName", "ModifiedDate", "SchoolNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4296), "Muhammet", "Marangoz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213025", 1 },
                    { 2, new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4689), "Duhan", "Avcı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213024", 1 },
                    { 3, new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4692), "Muha", "Mar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213026", 1 },
                    { 4, new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4693), "Duh", "Av", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213027", 1 }
                });

            migrationBuilder.InsertData(
                table: "studentsDetail",
                columns: new[] { "ID", "BirthDay", "DateTime", "Gender", "ModifiedDate", "PhoneNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(4976), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 2, new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5300), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2 },
                    { 3, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5303), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3 },
                    { 4, new DateTime(1994, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 2, 11, 39, 22, 41, DateTimeKind.Local).AddTicks(5304), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
