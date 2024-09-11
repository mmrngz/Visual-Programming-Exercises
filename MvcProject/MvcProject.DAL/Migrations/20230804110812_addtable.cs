using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcProject.DAL.Migrations
{
    public partial class addtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "appUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_appUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "bookTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    BookTypeID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_books_authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books_bookTypes_BookTypeID",
                        column: x => x.BookTypeID,
                        principalTable: "bookTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentsDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentsDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_studentsDetail_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "operations",
                columns: table => new
                {
                    BookID = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operations", x => new { x.StudentID, x.BookID });
                    table.ForeignKey(
                        name: "FK_operations_books_BookID",
                        column: x => x.BookID,
                        principalTable: "books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_operations_students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "appUsers",
                columns: new[] { "ID", "DateTime", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 4, 14, 8, 12, 485, DateTimeKind.Local).AddTicks(8279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$l8ikMilA4Y3u1bSeflqBLupDE04xLaXwdJvzJt.BZKGV97W8yYabu", 1, 1, "Muhammet" },
                    { 2, new DateTime(2023, 8, 4, 14, 8, 12, 486, DateTimeKind.Local).AddTicks(5352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$FOhRNB/UgdPOv/McjEgMz.X4pFZxUJR/kn6anc0RjuoN0bNre/1RK", 2, 1, "Duhan" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "ID", "DateTime", "FirstName", "LastName", "ModifiedDate", "SchoolNumber", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(3723), "Muhammet", "Marangoz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213025", 1 },
                    { 2, new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4139), "Duhan", "Avcı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213024", 1 },
                    { 3, new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4142), "Muha", "Mar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213026", 1 },
                    { 4, new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4145), "Duh", "Av", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2010213027", 1 }
                });

            migrationBuilder.InsertData(
                table: "studentsDetail",
                columns: new[] { "ID", "BirthDay", "DateTime", "Gender", "ModifiedDate", "PhoneNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4457), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 2, new DateTime(1996, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4812), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2 },
                    { 3, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4814), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3 },
                    { 4, new DateTime(1994, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 4, 14, 8, 12, 487, DateTimeKind.Local).AddTicks(4815), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books_AuthorID",
                table: "books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_books_BookTypeID",
                table: "books",
                column: "BookTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_operations_BookID",
                table: "operations",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_studentsDetail_StudentID",
                table: "studentsDetail",
                column: "StudentID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "appUsers");

            migrationBuilder.DropTable(
                name: "operations");

            migrationBuilder.DropTable(
                name: "studentsDetail");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "bookTypes");
        }
    }
}
