using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Specliazation",
                table: "Drivers",
                newName: "VechicalType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VechicalType",
                table: "Drivers",
                newName: "Specliazation");
        }
    }
}
