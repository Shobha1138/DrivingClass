using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Drivers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
