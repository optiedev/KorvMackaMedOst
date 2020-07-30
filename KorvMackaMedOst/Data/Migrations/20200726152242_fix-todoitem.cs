using Microsoft.EntityFrameworkCore.Migrations;

namespace KorvMackaMedOst.Data.Migrations
{
    public partial class fixtodoitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "TodoItems",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "TodoItems");
        }
    }
}
