using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class AddingRamColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ram",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ram",
                table: "Products");
        }
    }
}
