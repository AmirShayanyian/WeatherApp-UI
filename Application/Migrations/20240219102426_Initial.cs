using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighTemp = table.Column<int>(type: "int", nullable: true),
                    LowTemp = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TimeOfDay",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayId = table.Column<int>(type: "int", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TempC = table.Column<int>(type: "int", nullable: true),
                    TempF = table.Column<int>(type: "int", nullable: true),
                    Wind = table.Column<int>(type: "int", nullable: true),
                    UvIndex = table.Column<int>(type: "int", nullable: true),
                    Humidity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<int>(type: "int", nullable: true),
                    Pressure = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeOfDay", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TimeOfDay_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeOfDay_DayId",
                table: "TimeOfDay",
                column: "DayId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimeOfDay");

            migrationBuilder.DropTable(
                name: "Day");
        }
    }
}
