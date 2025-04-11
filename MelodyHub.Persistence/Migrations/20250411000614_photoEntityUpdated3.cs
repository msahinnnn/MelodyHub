using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MelodyHub.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class photoEntityUpdated3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Photos_PhotoId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Artist_ArtistId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ArtistId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Albums_PhotoId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Albums");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Photos",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Albums",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ArtistId",
                table: "Photos",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_PhotoId",
                table: "Albums",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Photos_PhotoId",
                table: "Albums",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Artist_ArtistId",
                table: "Photos",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "Id");
        }
    }
}
