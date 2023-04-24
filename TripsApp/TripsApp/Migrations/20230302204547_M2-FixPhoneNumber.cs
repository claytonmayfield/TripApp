using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripsApp.Migrations
{
    /// <inheritdoc />
    public partial class M2FixPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2,
                column: "AccommodationPhone",
                value: "503-555-1234");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2,
                column: "AccommodationPhone",
                value: "503-555-123");
        }
    }
}
