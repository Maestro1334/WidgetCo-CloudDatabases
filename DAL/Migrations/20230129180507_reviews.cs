using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Product_ProductId",
                table: "OrderProduct");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("057b3c63-8a72-4b1f-b2b3-cdaf0cab2441"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("4e15cb41-f020-4f17-a1d6-3d217ea13e9e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("e662e428-7975-4540-bc76-d03169196841"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("f43964f6-c911-4164-9d3e-635aba790213"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2283b71e-62da-4eac-a85a-e3fa21daa107"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42c77d3d-3810-4091-a39b-92438722eebe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("77fd0013-0f5f-45c5-bc0e-ff294904bc69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3a6cf82-96b7-4ee6-a0d6-d4bfdd1ef40a"));

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("0f047661-4eb8-4fa2-a508-6ccbe26d0f36"), "customer1@email.com", "secret" },
                    { new Guid("2717260d-b3a1-4654-ac42-77abf44ca3ed"), "customer3@email.com", "secret" },
                    { new Guid("319a358d-f89a-4d95-b8eb-71f2fe1b4ecf"), "customer2@email.com", "secret" },
                    { new Guid("a4cbc562-2432-4068-baf0-46f2ce73073b"), "customer4@email.com", "secret" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("38c4f4a1-7422-4c98-bac8-fbc71cb3f28c"), "Shoes", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Product D", 202.5 },
                    { new Guid("74459cc4-e3b2-4eda-aea0-153036a007eb"), "Sunglasses", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80", "Product C", 102.5 },
                    { new Guid("d809b461-edbe-41e5-8d77-05cfea6f5121"), "Headphones", "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Product B", 52.5 },
                    { new Guid("f86c44a4-9ffb-4352-87ed-bc43ad23d71c"), "Watch", "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1099&q=80", "Product A", 12.505000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProduct_Products_ProductId",
                table: "OrderProduct");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("0f047661-4eb8-4fa2-a508-6ccbe26d0f36"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2717260d-b3a1-4654-ac42-77abf44ca3ed"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("319a358d-f89a-4d95-b8eb-71f2fe1b4ecf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a4cbc562-2432-4068-baf0-46f2ce73073b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38c4f4a1-7422-4c98-bac8-fbc71cb3f28c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("74459cc4-e3b2-4eda-aea0-153036a007eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d809b461-edbe-41e5-8d77-05cfea6f5121"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f86c44a4-9ffb-4352-87ed-bc43ad23d71c"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Password" },
                values: new object[,]
                {
                    { new Guid("057b3c63-8a72-4b1f-b2b3-cdaf0cab2441"), "customer3@email.com", "secret" },
                    { new Guid("4e15cb41-f020-4f17-a1d6-3d217ea13e9e"), "customer2@email.com", "secret" },
                    { new Guid("e662e428-7975-4540-bc76-d03169196841"), "customer4@email.com", "secret" },
                    { new Guid("f43964f6-c911-4164-9d3e-635aba790213"), "customer1@email.com", "secret" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2283b71e-62da-4eac-a85a-e3fa21daa107"), "Shoes", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Product D", 202.5 },
                    { new Guid("42c77d3d-3810-4091-a39b-92438722eebe"), "Headphones", "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80", "Product B", 52.5 },
                    { new Guid("77fd0013-0f5f-45c5-bc0e-ff294904bc69"), "Watch", "https://images.unsplash.com/photo-1523275335684-37898b6baf30?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1099&q=80", "Product A", 12.505000000000001 },
                    { new Guid("d3a6cf82-96b7-4ee6-a0d6-d4bfdd1ef40a"), "Sunglasses", "https://images.unsplash.com/photo-1572635196237-14b3f281503f?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=880&q=80", "Product C", 102.5 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProduct_Product_ProductId",
                table: "OrderProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
