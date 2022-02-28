using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrivingClass.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specliazation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Learners",
                columns: table => new
                {
                    LearnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learners", x => x.LearnerId);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: true),
                    LearnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                    table.ForeignKey(
                        name: "FK_Appointments_Drivers_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Learners_LearnerId",
                        column: x => x.LearnerId,
                        principalTable: "Learners",
                        principalColumn: "LearnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverLearner",
                columns: table => new
                {
                    DriversDriverId = table.Column<int>(type: "int", nullable: false),
                    LearnersLearnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLearner", x => new { x.DriversDriverId, x.LearnersLearnerId });
                    table.ForeignKey(
                        name: "FK_DriverLearner_Drivers_DriversDriverId",
                        column: x => x.DriversDriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverLearner_Learners_LearnersLearnerId",
                        column: x => x.LearnersLearnerId,
                        principalTable: "Learners",
                        principalColumn: "LearnerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_LearnerId",
                table: "Appointments",
                column: "LearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLearner_LearnersLearnerId",
                table: "DriverLearner",
                column: "LearnersLearnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "DriverLearner");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Learners");
        }
    }
}
