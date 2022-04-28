using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShop.Migrations
{
    public partial class SneakerSizeToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SneakerSizeOrder",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SneakerSizeOrder",
                table: "Orders");
        }
    }
}
