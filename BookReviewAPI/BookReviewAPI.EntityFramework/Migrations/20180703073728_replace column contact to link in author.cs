using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewAPI.EntityFramework.Migrations
{
    public partial class replacecolumncontacttolinkinauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Authors",
                newName: "Link");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Authors",
                newName: "Contact");
        }
    }
}
