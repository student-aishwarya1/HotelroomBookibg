using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBooking.Migrations
{
    /// <inheritdoc />
    public partial class four : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelDetails_City_CityId",
                table: "HotelDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelDetails",
                table: "HotelDetails");

            migrationBuilder.RenameTable(
                name: "HotelDetails",
                newName: "HotelDetail");

            migrationBuilder.RenameIndex(
                name: "IX_HotelDetails_CityId",
                table: "HotelDetail",
                newName: "IX_HotelDetail_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelDetail",
                table: "HotelDetail",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelDetail_City_CityId",
                table: "HotelDetail",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelDetail_City_CityId",
                table: "HotelDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelDetail",
                table: "HotelDetail");

            migrationBuilder.RenameTable(
                name: "HotelDetail",
                newName: "HotelDetails");

            migrationBuilder.RenameIndex(
                name: "IX_HotelDetail_CityId",
                table: "HotelDetails",
                newName: "IX_HotelDetails_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelDetails",
                table: "HotelDetails",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelDetails_City_CityId",
                table: "HotelDetails",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
