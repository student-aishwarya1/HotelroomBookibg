using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class abhijit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Check_in",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Check_out",
                table: "Bookings");

            migrationBuilder.AlterColumn<long>(
                name: "Contact",
                table: "Bookings",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "checkInDate",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "checkInTime",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "checkOutDate",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "checkOutTime",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "person",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "roomType",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkInDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "checkInTime",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "checkOutDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "checkOutTime",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "person",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "roomType",
                table: "Bookings");

            migrationBuilder.AlterColumn<int>(
                name: "Contact",
                table: "Bookings",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "Check_in",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Check_out",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
