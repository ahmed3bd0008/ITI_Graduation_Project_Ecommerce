using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MahaleSystem.Migrations
{
    public partial class addrables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "manahels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ssn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlowerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Account_ID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manahels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagesString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabelId = table.Column<int>(type: "int", nullable: false),
                    TabelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManahelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_manahels_ManahelId",
                        column: x => x.ManahelId,
                        principalTable: "manahels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "khaliases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ssn = table.Column<int>(type: "int", nullable: false),
                    KhaliaLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhaliaType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PraweezCount = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManhalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khaliases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_khaliases_manahels_ManhalId",
                        column: x => x.ManhalId,
                        principalTable: "manahels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatePick = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlowerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManhalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_manahels_ManhalId",
                        column: x => x.ManhalId,
                        principalTable: "manahels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Queues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueueStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateFertilization = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KhaliaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Queues_khaliases_KhaliaId",
                        column: x => x.KhaliaId,
                        principalTable: "khaliases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ManahelId",
                table: "Images",
                column: "ManahelId");

            migrationBuilder.CreateIndex(
                name: "IX_khaliases_ManhalId",
                table: "khaliases",
                column: "ManhalId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManhalId",
                table: "Products",
                column: "ManhalId");

            migrationBuilder.CreateIndex(
                name: "IX_Queues_KhaliaId",
                table: "Queues",
                column: "KhaliaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Queues");

            migrationBuilder.DropTable(
                name: "khaliases");

            migrationBuilder.DropTable(
                name: "manahels");
        }
    }
}
