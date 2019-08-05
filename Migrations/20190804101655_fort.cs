using Microsoft.EntityFrameworkCore.Migrations;

namespace ScreenProject.Migrations
{
    public partial class fort : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "EventFields",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Value",
                table: "EventFields",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
