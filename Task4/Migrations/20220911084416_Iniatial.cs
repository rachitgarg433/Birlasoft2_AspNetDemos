using Microsoft.EntityFrameworkCore.Migrations;

namespace Task4.Migrations
{
    public partial class Iniatial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

        }
    }
}
