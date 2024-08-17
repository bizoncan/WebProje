using Microsoft.EntityFrameworkCore.Migrations;

namespace veriErisimK.Migrations
{
    public partial class mig_add_portfolio_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "img1",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img2",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img3",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "img4",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "platform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "price",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "Portfolios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "value",
                table: "Portfolios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "img1",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "img2",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "img3",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "img4",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "platform",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "value",
                table: "Portfolios");
        }
    }
}
