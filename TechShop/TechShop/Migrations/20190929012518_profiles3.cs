using Microsoft.EntityFrameworkCore.Migrations;

namespace TechShop.Migrations
{
    public partial class profiles3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrdouctFK",
                table: "Profile");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Profile",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_ProductId",
                table: "Profile",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Products_ProductId",
                table: "Profile",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Products_ProductId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_ProductId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Profile");

            migrationBuilder.AddColumn<int>(
                name: "PrdouctFK",
                table: "Profile",
                nullable: false,
                defaultValue: 0);
        }
    }
}
