using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MnsGames.Migrations
{
    public partial class AddDescriptionToTheme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Themes",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Themes");

        }
    }
}
