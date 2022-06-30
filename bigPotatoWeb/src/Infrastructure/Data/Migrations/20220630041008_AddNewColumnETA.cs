using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microsoft.bigPotatoWeb.Infrastructure.Data.Migrations
{
    public partial class AddNewColumnETA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ETA",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ETA",
                table: "Catalog",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ETA",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ETA",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "ETA",
                table: "Catalog");

            migrationBuilder.DropColumn(
                name: "ETA",
                table: "BasketItems");
        }
    }
}
