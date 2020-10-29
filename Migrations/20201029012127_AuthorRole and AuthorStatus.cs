using Microsoft.EntityFrameworkCore.Migrations;

namespace FictionDataLayer.Migrations
{
    public partial class AuthorRoleandAuthorStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Authors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Authors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Authors");
        }
    }
}
