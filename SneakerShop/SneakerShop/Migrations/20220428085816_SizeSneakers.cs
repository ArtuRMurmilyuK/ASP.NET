using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShop.Migrations
{
    public partial class SizeSneakers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Sneakers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Sneakers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Sneakers");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Sneakers");
        }
    }
}
