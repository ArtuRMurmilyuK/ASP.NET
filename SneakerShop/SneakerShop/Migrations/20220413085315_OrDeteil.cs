using Microsoft.EntityFrameworkCore.Migrations;

namespace SneakerShop.Migrations
{
    public partial class OrDeteil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SneakerName",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "SneakerName",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "OrderDetail");
        }
    }
}
