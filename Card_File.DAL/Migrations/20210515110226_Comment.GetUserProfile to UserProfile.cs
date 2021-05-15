using Microsoft.EntityFrameworkCore.Migrations;

namespace Card_File.DAL.Migrations
{
    public partial class CommentGetUserProfiletoUserProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Categoryname",
                table: "Categories",
                newName: "CategoryName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Categoryname");
        }
    }
}
