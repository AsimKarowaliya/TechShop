using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Products",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
