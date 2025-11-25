using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeePortal.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Designations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeTypeId = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Employees_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "EmployeeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, false, "ИТ" },
                    { 2, false, "HR" },
                    { 3, false, "Продажи" },
                    { 4, false, "Администрация" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, false, "Постоянный" },
                    { 2, false, "Временный" },
                    { 3, false, "Контракт" },
                    { 4, false, "Стажер" }
                });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "Id", "DepartmentId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "Разработчик ПО" },
                    { 2, 1, false, "Системный администратор" },
                    { 3, 1, false, "Сетевой инженер" },
                    { 4, 2, false, "HR специалист" },
                    { 5, 2, false, "HR менеджер" },
                    { 6, 2, false, "Координатор по подбору персонала" },
                    { 7, 3, false, "Менеджер по продажам" },
                    { 8, 3, false, "Руководитель отдела продаж" },
                    { 9, 3, false, "Аккаунт-менеджер" },
                    { 10, 4, false, "Офис-менеджер" },
                    { 11, 4, false, "Помощник руководителя" },
                    { 12, 4, false, "Секретарь" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "DesignationId", "Email", "EmployeeTypeId", "FullName", "Gender", "HireDate", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "ivan@example.com", 1, "Иван Иванов", "Мужской", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 60000m },
                    { 2, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "maria@example.com", 1, "Мария Петрова", "Женский", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 80000m },
                    { 3, new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, "sergey@example.com", 3, "Сергей Смирнов", "Мужской", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50000m },
                    { 4, new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11, "anna@example.com", 2, "Анна Кузнецова", "Женский", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40000m },
                    { 5, new DateTime(1989, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "dmitry@example.com", 1, "Дмитрий Попов", "Мужской", new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70000m },
                    { 6, new DateTime(1987, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "elena@example.com", 1, "Елена Васильева", "Женский", new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 75000m },
                    { 7, new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, "alexey@example.com", 3, "Алексей Морозов", "Мужской", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 85000m },
                    { 8, new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10, "olga@example.com", 1, "Ольга Новикова", "Женский", new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 65000m },
                    { 9, new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "sofia@example.com", 4, "София Воробьева", "Женский", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30000m },
                    { 10, new DateTime(1986, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, "kirill@example.com", 2, "Кирилл Федоров", "Другой", new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55000m },
                    { 11, new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, "alisa@example.com", 1, "Алиса Белова", "Женский", new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 52000m },
                    { 12, new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 12, "artem@example.com", 2, "Артем Громов", "Мужской", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 38000m },
                    { 13, new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "maxim@example.com", 1, "Максим Орлов", "Мужской", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65000m },
                    { 14, new DateTime(1988, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "victoria@example.com", 1, "Виктория Лебедева", "Женский", new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 76000m },
                    { 15, new DateTime(1993, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, "pavel@example.com", 3, "Павел Соколов", "Мужской", new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 62000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Designations_DepartmentId",
                table: "Designations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationId",
                table: "Employees",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeTypeId",
                table: "Employees",
                column: "EmployeeTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "EmployeeTypes");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
