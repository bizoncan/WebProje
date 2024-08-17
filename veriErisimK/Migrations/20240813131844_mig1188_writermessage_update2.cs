using Microsoft.EntityFrameworkCore.Migrations;

namespace veriErisimK.Migrations
{
    public partial class mig1188_writermessage_update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "recieverName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "senderName",
                table: "WriterMessages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "recieverName",
                table: "WriterMessages");

            migrationBuilder.DropColumn(
                name: "senderName",
                table: "WriterMessages");
        }
    }
}
