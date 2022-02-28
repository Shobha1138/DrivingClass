using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "File",
                table: "Drivers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Drivers");
        }
    }
}
