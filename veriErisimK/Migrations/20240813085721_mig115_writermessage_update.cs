using Microsoft.EntityFrameworkCore.Migrations;

namespace veriErisimK.Migrations
{
    public partial class mig115_writermessage_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages");

            migrationBuilder.RenameTable(
                name: "writerMessages",
                newName: "WriterMessages");

            migrationBuilder.RenameColumn(
                name: "content",
                table: "WriterMessages",
                newName: "messageContent");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages",
                column: "writerMessageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WriterMessages",
                table: "WriterMessages");

            migrationBuilder.RenameTable(
                name: "WriterMessages",
                newName: "writerMessages");

            migrationBuilder.RenameColumn(
                name: "messageContent",
                table: "writerMessages",
                newName: "content");

            migrationBuilder.AddPrimaryKey(
                name: "PK_writerMessages",
                table: "writerMessages",
                column: "writerMessageID");
        }
    }
}
