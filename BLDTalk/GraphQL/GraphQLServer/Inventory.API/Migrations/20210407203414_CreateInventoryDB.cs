using Microsoft.EntityFrameworkCore.Migrations;

namespace Inventory.API.Migrations
{
    public partial class CreateInventoryDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    SKU = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_SKU",
                table: "Inventory",
                column: "SKU",
                unique: true,
                filter: "[SKU] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventory");
        }
    }
}
