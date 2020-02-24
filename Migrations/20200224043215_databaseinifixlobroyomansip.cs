using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Migrations
{
    public partial class databaseinifixlobroyomansip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nama",
                table: "Chats");

            migrationBuilder.AddColumn<string>(
                name: "from",
                table: "Chats",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "to",
                table: "Chats",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "from",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "to",
                table: "Chats");

            migrationBuilder.AddColumn<string>(
                name: "nama",
                table: "Chats",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
