using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ALevelSample.Migrations
{
    public partial class AddPets1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_CategoryId",
                table: "Pet",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Category_CategoryId",
                table: "Pet",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Category_CategoryId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_CategoryId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Pet");
        }
    }
}
