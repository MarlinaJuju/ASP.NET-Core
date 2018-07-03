using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewAPI.EntityFramework.Migrations
{
    public partial class replacecolumnemailtocontactinauthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Authors",
                newName: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "Authors",
                newName: "Email");
        }
    }
}
