using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefDish.Migrations
{
    public partial class fk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChefId",
                table: "LosPlatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "LosGatos",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DishId",
                table: "LosGatos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "LosPlatos");

            migrationBuilder.DropColumn(
                name: "DishId",
                table: "LosGatos");

            migrationBuilder.AlterColumn<int>(
                name: "Birthday",
                table: "LosGatos",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
