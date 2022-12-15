using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChefsNDishes.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefId",
                table: "Dishes");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Dishes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CreatorChefId",
                table: "Dishes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefId",
                table: "Dishes",
                column: "CreatorChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefId",
                table: "Dishes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dishes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "CreatorChefId",
                table: "Dishes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefId",
                table: "Dishes",
                column: "CreatorChefId",
                principalTable: "Chefs",
                principalColumn: "ChefId");
        }
    }
}
