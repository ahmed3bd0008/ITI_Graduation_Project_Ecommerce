using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MahaleSystem.Migrations
{
    public partial class addProductSellTableAndProductPublish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c0685ef6-7bb5-4f40-8da3-7c97993f82a2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fce6a2b1-4c9e-4480-876c-dd440fe4a50e");

            migrationBuilder.CreateTable(
                name: "ProductPublish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datePublish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProdcutID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPublish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPublish_Products_ProdcutID",
                        column: x => x.ProdcutID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductSells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrioductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductAmount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    dateSell = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdcutID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSells_Products_ProdcutID",
                        column: x => x.ProdcutID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed12f830-229f-4d20-b8dd-11908d292a46", "636c7c7b-c853-4ba3-a5de-8297a0af9c7c", "SuperAdmin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56d16927-2bc1-4de6-aff7-a68afee72fa8", "ca8c125a-6001-4eb6-aa23-d5040290ec7e", "Admin", null });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPublish_ProdcutID",
                table: "ProductPublish",
                column: "ProdcutID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSells_ProdcutID",
                table: "ProductSells",
                column: "ProdcutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPublish");

            migrationBuilder.DropTable(
                name: "ProductSells");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d16927-2bc1-4de6-aff7-a68afee72fa8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed12f830-229f-4d20-b8dd-11908d292a46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c0685ef6-7bb5-4f40-8da3-7c97993f82a2", "81fa8cca-27d3-4d37-a78b-f56fc01073ae", "SuperAdmin", null });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fce6a2b1-4c9e-4480-876c-dd440fe4a50e", "5b292168-9d41-44e7-9856-145f16d58817", "Admin", null });
        }
    }
}
