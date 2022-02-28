using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "Learners");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "Learners",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
