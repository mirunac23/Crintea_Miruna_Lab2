using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crintea_Miruna_Lab2.Migrations
{
    public partial class ChangeFieldNameForAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublisherName",
                table: "Author",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Author",
                newName: "PublisherName");
        }
    }
}
