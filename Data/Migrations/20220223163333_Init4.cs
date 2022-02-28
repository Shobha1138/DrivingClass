using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Drivers_DoctorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DriverrId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DriverId",
                table: "Appointments",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Drivers_DriverId",
                table: "Appointments",
                column: "DriverId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Drivers_DriverId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DriverId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "DriverrId",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "DriverId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Drivers_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
