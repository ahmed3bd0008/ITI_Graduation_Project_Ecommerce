using Microsoft.EntityFrameworkCore.Migrations;

namespace MahaleSystem.Migrations
{
    public partial class changeinAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_manahels_ManahelId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TabelId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "TabelName",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "ManahelId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_manahels_ManahelId",
                table: "Images",
                column: "ManahelId",
                principalTable: "manahels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_manahels_ManahelId",
                table: "Images");

            migrationBuilder.AlterColumn<int>(
                name: "ManahelId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TabelId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TabelName",
                table: "Images",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_manahels_ManahelId",
                table: "Images",
                column: "ManahelId",
                principalTable: "manahels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
