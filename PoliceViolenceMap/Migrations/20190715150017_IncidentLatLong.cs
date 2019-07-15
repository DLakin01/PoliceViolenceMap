using Microsoft.EntityFrameworkCore.Migrations;

namespace PoliceViolenceMap.Migrations
{
    public partial class IncidentLatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "PoliceKillings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "PoliceKillings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "PoliceKillings");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "PoliceKillings");
        }
    }
}
