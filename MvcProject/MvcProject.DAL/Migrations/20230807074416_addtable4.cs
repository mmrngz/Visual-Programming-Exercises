using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.DAL.Migrations
{
    public partial class addtable4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 44, 15, 804, DateTimeKind.Local).AddTicks(7104), "$2a$11$d93p0ztAVc41mIKT3AsX8uan5d7GhAddZxAw7rY9phCYvPHiRGqtO" });

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 7, 10, 44, 15, 805, DateTimeKind.Local).AddTicks(2822), "$2a$11$1Xm4VKNZIKgh03INBRpx5.Kp/euZMXu3RHq71VFsz9pb8EFbSUlee" });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 7, 10, 44, 15, 806, DateTimeKind.Local).AddTicks(1134));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 8, 12, 485, DateTimeKind.Local).AddTicks(8279), "$2a$11$l8ikMilA4Y3u1bSeflqBLupDE04xLaXwdJvzJt.BZKGV97W8yYabu" });

            migrationBuilder.UpdateData(
                table: "appUsers",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateTime", "Password" },
                values: new object[] { new DateTime(2023, 8, 4, 14, 8, 12, 486, DateTimeKind.Local).AddTicks(5352), "$2a$11$FOhRNB/UgdPOv/McjEgMz.X4pFZxUJR/kn6anc0RjuoN0bNre/1RK" });

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "studentsDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4815));
        }
    }
}
