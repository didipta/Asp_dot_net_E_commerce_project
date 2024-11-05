using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace layoutdesign.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "044f5a98-87d3-4567-b404-0dc37fe2240b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2023c428-405a-4cba-8b47-c4ffc3a42333");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28303493-5c09-4373-8fc0-332adb4824a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68f56445-3fc7-47fc-a81e-a869dceabd6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea6d30c-28fd-4854-b3ac-795c6e5cf914");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e01081e8-399b-437d-9947-49fd3d6af5ec");

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

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsRemoved", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Inc. is an American multinational technology company that specializes in consumer electronics, computer software, and online services. Apple is the world's largest technology company by revenue and, since January 2021, the world's most valuable company.", "https://www.apple.com/ac/structured-data/images/knowledge_graph_logo.png?201810271738", false, false, "Apple", null, null },
                    { 2L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Electronics Co., Ltd. is a South Korean multinational electronics company headquartered in the Yeongtong District of Suwon. It is the pinnacle of the Samsung chaebol, accounting for 70% of the group's revenue in 2012.", "https://www.samsung.com/etc/designs/smg/global/imgs/logo-square-letter.png", false, false, "Samsung", null, null }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "IsActive", "IsRemoved", "Name", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Devices and gadgets including phones, laptops, and more.", "https://example.com/images/electronics.jpg", false, false, "Electronics", null, null },
                    { 2L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clothing, accessories, and fashion products.", "https://example.com/images/fashion.jpg", false, false, "Fashion", null, null },
                    { 3L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Appliances for everyday household needs.", "https://example.com/images/home_appliances.jpg", false, false, "Home Appliances", null, null },
                    { 4L, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A variety of books and reading materials.", "https://example.com/images/books.jpg", false, false, "Books", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "044f5a98-87d3-4567-b404-0dc37fe2240b", null, "SuperAdmin", "SUPERADMIN" },
                    { "2023c428-405a-4cba-8b47-c4ffc3a42333", null, "Manager", "MANAGER" },
                    { "28303493-5c09-4373-8fc0-332adb4824a9", null, "User", "USER" },
                    { "68f56445-3fc7-47fc-a81e-a869dceabd6c", null, "Employe", "EMPLOYE" },
                    { "dea6d30c-28fd-4854-b3ac-795c6e5cf914", null, "deliveryMan", "DELIVERYMAN" },
                    { "e01081e8-399b-437d-9947-49fd3d6af5ec", null, "Admin", "ADMIN" }
                });
        }
    }
}
