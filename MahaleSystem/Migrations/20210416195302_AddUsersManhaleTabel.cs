using Microsoft.EntityFrameworkCore.Migrations;

namespace MahaleSystem.Migrations
{
    public partial class AddUsersManhaleTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersManhals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManelId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersManhals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersManhals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersManhals_Manahels_ManelId",
                        column: x => x.ManelId,
                        principalTable: "Manahels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersManhals_ManelId",
                table: "UsersManhals",
                column: "ManelId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersManhals_UserId",
                table: "UsersManhals",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersManhals");
        }
    }
}
