using Microsoft.EntityFrameworkCore.Migrations;

namespace veriErisimK.Migrations
{
    public partial class migaddcolumn_portfolio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imageURL2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "projectURL",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageURL2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "projectURL",
                table: "Portfolios");
        }
    }
}
