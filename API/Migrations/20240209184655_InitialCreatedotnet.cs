using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    [ExcludeFromCodeCoverage]
    public partial class InitialCreatedotnet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    Phone = table.Column<string>(type: "longtext", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IsActived = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "DateTime", "Description", "IsActived", "LastName", "Name", "Phone" },
                values: new object[,]
                {
                    { new Guid("18749e3c-7465-4360-bc60-624ed021013d"), new DateTime(2024, 2, 9, 13, 46, 52, 594, DateTimeKind.Local).AddTicks(6997), null, false, "LastName 2", "User 2", null },
                    { new Guid("1e714b8e-427b-477a-aaea-c4985163067e"), new DateTime(2024, 2, 9, 13, 46, 52, 594, DateTimeKind.Local).AddTicks(6980), null, false, "LastName 1", "User 1", null },
                    { new Guid("8abd9ced-a210-4ebf-b241-6bb14e2178dc"), new DateTime(2024, 2, 9, 13, 46, 52, 594, DateTimeKind.Local).AddTicks(6999), null, false, "LastName 3", "User 3", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
