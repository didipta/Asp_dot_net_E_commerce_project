using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace layoutdesign.Migrations
{
    /// <inheritdoc />
    public partial class loggerupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Exception",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03587891-9a1d-4c82-bc0e-3bd4ce4da50d", null, "User", "USER" },
                    { "05bc57b6-847f-4485-9f12-c3cfdbe6a661", null, "deliveryMan", "DELIVERYMAN" },
                    { "78b42732-be54-4557-accb-97bf29fcf41f", null, "Employe", "EMPLOYE" },
                    { "d0d8c0a6-7f37-4803-9dcf-649e46203a91", null, "SuperAdmin", "SUPERADMIN" },
                    { "ddc6c3a4-cba6-4a3c-8636-a3185019c7c3", null, "Manager", "MANAGER" },
                    { "e15e8616-b091-48ee-ab7e-25606683a5df", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03587891-9a1d-4c82-bc0e-3bd4ce4da50d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05bc57b6-847f-4485-9f12-c3cfdbe6a661");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78b42732-be54-4557-accb-97bf29fcf41f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0d8c0a6-7f37-4803-9dcf-649e46203a91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddc6c3a4-cba6-4a3c-8636-a3185019c7c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e15e8616-b091-48ee-ab7e-25606683a5df");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Exception",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
