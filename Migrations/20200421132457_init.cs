using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefDish.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LosGatos",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    CatType = table.Column<string>(nullable: false),
                    Birthday = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LosGatos", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "LosPlatos",
                columns: table => new
                {
                    DishId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DishName = table.Column<string>(nullable: false),
                    Tastiness = table.Column<int>(nullable: false),
                    Calories = table.Column<int>(nullable: false),
                    CreatorCatId = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LosPlatos", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_LosPlatos_LosGatos_CreatorCatId",
                        column: x => x.CreatorCatId,
                        principalTable: "LosGatos",
                        principalColumn: "CatId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LosPlatos_CreatorCatId",
                table: "LosPlatos",
                column: "CreatorCatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LosPlatos");

            migrationBuilder.DropTable(
                name: "LosGatos");
        }
    }
}
