using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefDish.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LosPlatos_LosGatos_CreatorCatId",
                table: "LosPlatos");

            migrationBuilder.DropIndex(
                name: "IX_LosPlatos_CreatorCatId",
                table: "LosPlatos");

            migrationBuilder.DropColumn(
                name: "CreatorCatId",
                table: "LosPlatos");

            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "LosPlatos",
                newName: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_LosPlatos_CatId",
                table: "LosPlatos",
                column: "CatId");

            migrationBuilder.AddForeignKey(
                name: "FK_LosPlatos_LosGatos_CatId",
                table: "LosPlatos",
                column: "CatId",
                principalTable: "LosGatos",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LosPlatos_LosGatos_CatId",
                table: "LosPlatos");

            migrationBuilder.DropIndex(
                name: "IX_LosPlatos_CatId",
                table: "LosPlatos");

            migrationBuilder.RenameColumn(
                name: "CatId",
                table: "LosPlatos",
                newName: "ChefId");

            migrationBuilder.AddColumn<int>(
                name: "CreatorCatId",
                table: "LosPlatos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LosPlatos_CreatorCatId",
                table: "LosPlatos",
                column: "CreatorCatId");

            migrationBuilder.AddForeignKey(
                name: "FK_LosPlatos_LosGatos_CreatorCatId",
                table: "LosPlatos",
                column: "CreatorCatId",
                principalTable: "LosGatos",
                principalColumn: "CatId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
