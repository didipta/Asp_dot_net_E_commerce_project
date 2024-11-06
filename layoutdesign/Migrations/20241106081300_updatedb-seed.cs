using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace layoutdesign.Migrations
{
    /// <inheritdoc />
    public partial class updatedbseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "226e6a3a-5aab-489c-a3eb-d5bea6cb834d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cfb6322-0e95-42f6-99dd-8e660858ece9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5776c109-33e7-49e7-8e44-b46e3c39c6a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b0e898e-6994-4201-9b90-0fa34a020018");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9367e446-a090-4c01-8ae9-1d1d174625bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be95582f-c8e4-4934-bfb3-c1b8dc3e1328");

            migrationBuilder.AddColumn<string>(
                name: "slug",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "slug",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "slug",
                table: "Brands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1628d580-eaa0-470d-b127-d16bbcf3f581", null, "SuperAdmin", "SUPERADMIN" },
                    { "1b125db6-f66e-48ac-98a3-826d41220fbf", null, "Admin", "ADMIN" },
                    { "45332bca-5801-4a5c-b3f6-e0e4672c35ed", null, "User", "USER" },
                    { "bb090e71-5fce-4deb-9059-dcfc91392bff", null, "Employe", "EMPLOYE" },
                    { "c5ffdba3-52f3-4548-b145-441ff51d10b3", null, "deliveryMan", "DELIVERYMAN" },
                    { "f705538c-e7e4-44e1-9081-bc64f28399cf", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "slug",
                value: "apple");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "slug",
                value: "samsung");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "slug",
                value: "electronics");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "slug",
                value: "fashion");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "slug",
                value: "home-appliances");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "slug",
                value: "books");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1628d580-eaa0-470d-b127-d16bbcf3f581");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b125db6-f66e-48ac-98a3-826d41220fbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45332bca-5801-4a5c-b3f6-e0e4672c35ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb090e71-5fce-4deb-9059-dcfc91392bff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5ffdba3-52f3-4548-b145-441ff51d10b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f705538c-e7e4-44e1-9081-bc64f28399cf");

            migrationBuilder.DropColumn(
                name: "slug",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "slug",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "slug",
                table: "Brands");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "226e6a3a-5aab-489c-a3eb-d5bea6cb834d", null, "deliveryMan", "DELIVERYMAN" },
                    { "4cfb6322-0e95-42f6-99dd-8e660858ece9", null, "Admin", "ADMIN" },
                    { "5776c109-33e7-49e7-8e44-b46e3c39c6a3", null, "SuperAdmin", "SUPERADMIN" },
                    { "8b0e898e-6994-4201-9b90-0fa34a020018", null, "Manager", "MANAGER" },
                    { "9367e446-a090-4c01-8ae9-1d1d174625bd", null, "User", "USER" },
                    { "be95582f-c8e4-4934-bfb3-c1b8dc3e1328", null, "Employe", "EMPLOYE" }
                });
        }
    }
}
