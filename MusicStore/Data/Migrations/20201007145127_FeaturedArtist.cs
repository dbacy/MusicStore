using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicStore.Data.Migrations
{
    public partial class FeaturedArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FeaturedArtist",
                table: "Music",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeaturedArtist",
                table: "Music");
        }
    }
}
