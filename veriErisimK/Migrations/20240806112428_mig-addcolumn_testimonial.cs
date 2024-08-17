using Microsoft.EntityFrameworkCore.Migrations;

namespace veriErisimK.Migrations
{
    public partial class migaddcolumn_testimonial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Testimonials",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "title",
                table: "Testimonials");
        }
    }
}
