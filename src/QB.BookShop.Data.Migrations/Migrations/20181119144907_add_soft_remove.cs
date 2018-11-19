using Microsoft.EntityFrameworkCore.Migrations;

namespace QB.BookShop.Data.Migrations.Migrations
{
    public partial class add_soft_remove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Books",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "Authors",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "Authors");
        }
    }
}
