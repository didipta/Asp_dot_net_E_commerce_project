using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace layoutdesign.Migrations
{
    /// <inheritdoc />
    public partial class logger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0695d142-5b3f-44b0-92f5-35454d588e30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13eb00f2-d596-4880-b840-c8f14eb734d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7a9ffae-0513-4507-8acb-61010cfe9ea5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc69e0fa-f4ef-4476-a92d-b8fb3a7a7079");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa86e594-ed9a-4d2a-a3b2-620cd42cc3a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd2a05f8-0ba0-4446-bf5a-0d84ccfe7327");

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1069d32f-7eb4-4272-b027-314d5a023ec5", null, "Manager", "MANAGER" },
                    { "25c0af99-021e-4380-ade0-2fa8bbdeb93e", null, "deliveryMan", "DELIVERYMAN" },
                    { "46f2ec13-20d6-4375-8bdb-5a81490e368f", null, "User", "USER" },
                    { "dc13c5a6-db75-4a2f-b4de-b7a4bbcbc3bc", null, "SuperAdmin", "SUPERADMIN" },
                    { "e9bb974d-1604-40e1-b151-57ab2fd14dd8", null, "Employe", "EMPLOYE" },
                    { "ee26e4c2-b13a-4142-9268-9ccccc74bf18", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1069d32f-7eb4-4272-b027-314d5a023ec5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25c0af99-021e-4380-ade0-2fa8bbdeb93e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46f2ec13-20d6-4375-8bdb-5a81490e368f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc13c5a6-db75-4a2f-b4de-b7a4bbcbc3bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e9bb974d-1604-40e1-b151-57ab2fd14dd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee26e4c2-b13a-4142-9268-9ccccc74bf18");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0695d142-5b3f-44b0-92f5-35454d588e30", null, "deliveryMan", "DELIVERYMAN" },
                    { "13eb00f2-d596-4880-b840-c8f14eb734d4", null, "Manager", "MANAGER" },
                    { "c7a9ffae-0513-4507-8acb-61010cfe9ea5", null, "User", "USER" },
                    { "dc69e0fa-f4ef-4476-a92d-b8fb3a7a7079", null, "Admin", "ADMIN" },
                    { "fa86e594-ed9a-4d2a-a3b2-620cd42cc3a5", null, "SuperAdmin", "SUPERADMIN" },
                    { "fd2a05f8-0ba0-4446-bf5a-0d84ccfe7327", null, "Employe", "EMPLOYE" }
                });
        }
    }
}
