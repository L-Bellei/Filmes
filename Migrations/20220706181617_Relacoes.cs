using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmes.Migrations
{
    public partial class Relacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "language_id",
                table: "film",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "original_language_id",
                table: "film",
                type: "tinyint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_film_language_id",
                table: "film",
                column: "language_id");

            migrationBuilder.CreateIndex(
                name: "IX_film_original_language_id",
                table: "film",
                column: "original_language_id");

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_language_id",
                table: "film",
                column: "language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film",
                column: "original_language_id",
                principalTable: "language",
                principalColumn: "language_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_film_language_language_id",
                table: "film");

            migrationBuilder.DropForeignKey(
                name: "FK_film_language_original_language_id",
                table: "film");

            migrationBuilder.DropIndex(
                name: "IX_film_language_id",
                table: "film");

            migrationBuilder.DropIndex(
                name: "IX_film_original_language_id",
                table: "film");

            migrationBuilder.DropColumn(
                name: "language_id",
                table: "film");

            migrationBuilder.DropColumn(
                name: "original_language_id",
                table: "film");
        }
    }
}
