using Microsoft.EntityFrameworkCore.Migrations;

namespace MahaleSystem.Migrations
{
    public partial class add_seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "41fba480-48ff-411e-b3d6-8b08e083bb38", "3edce971-6d1e-481a-8b82-cf3e52b05c6a", "SuperAdmin", "SUPERADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec035abe-a3b6-464f-ae37-fea066e0e251", "9e05bbbd-7996-4b51-bdc6-abd925abe840", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41fba480-48ff-411e-b3d6-8b08e083bb38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec035abe-a3b6-464f-ae37-fea066e0e251");
        }
    }
}
