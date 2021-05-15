using Microsoft.EntityFrameworkCore.Migrations;

namespace Card_File.DAL.Migrations
{
    public partial class AddIsHidefieldstomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHide",
                table: "TextMaterials",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHide",
                table: "Comments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "TextMaterials");

            migrationBuilder.DropColumn(
                name: "IsHide",
                table: "Comments");
        }
    }
}
