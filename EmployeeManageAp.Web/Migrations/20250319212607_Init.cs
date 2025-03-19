using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManageAp.Web.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DepartmentId = table.Column<int>(type: "INTEGER", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true),
                    DeletedBy = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Admin Test", new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, false, null, null, "Finance" },
                    { 2, "Admin Test", new DateTime(2025, 3, 25, 0, 2, 30, 0, DateTimeKind.Unspecified), null, null, false, null, null, "Development" },
                    { 3, "Admin Test", new DateTime(2025, 3, 25, 0, 4, 54, 0, DateTimeKind.Unspecified), null, null, false, null, null, "IT" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Address", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "DepartmentId", "Email", "FirstName", "Gender", "IsDeleted", "LastName", "ModifiedBy", "ModifiedDate", "Phone" },
                values: new object[,]
                {
                    { 1, "Etimesgut/Ankara", "Admin Test", new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1, "engindemrog@mail.com", "Engin", "Male", false, "Demiroğ", null, null, "212 435 45 23" },
                    { 2, "Bahçeşehir/İstanbul", "Admin Test", new DateTime(2025, 3, 13, 0, 3, 6, 0, DateTimeKind.Unspecified), null, null, 2, "gokhankandemir@mail.com", "Gökhan", "Male", false, "Kandemir", null, null, "212 334 21 21" },
                    { 3, "Mecidiyeköy/İstanbul", "Admin Test", new DateTime(2025, 3, 13, 0, 4, 27, 0, DateTimeKind.Unspecified), null, null, 3, "muratyucedag@mail.com", "Murat", "Male", false, "Yücedağ", null, null, "212 663 43 87" },
                    { 4, "Çarşamba/Samsun", "Admin Test", new DateTime(2025, 3, 13, 0, 7, 19, 200, DateTimeKind.Unspecified), null, null, 2, "zafercomert@mail.com", "Zafer", "Male", false, "Cömert", null, null, "212 776 55 42" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
