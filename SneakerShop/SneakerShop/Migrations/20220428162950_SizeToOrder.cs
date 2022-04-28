using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShop.Migrations
{
    public partial class SizeToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SneakerSize",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SneakerSize",
                table: "OrderDetail");
        }
    }
}
