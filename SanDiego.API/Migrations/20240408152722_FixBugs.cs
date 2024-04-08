using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SanDiego.API.Migrations
{
    /// <inheritdoc />
    public partial class FixBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Rooms",
                newName: "RoomType");

            migrationBuilder.RenameColumn(
                name: "Stauts",
                table: "Rooms",
                newName: "RoomStatus");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RoomType",
                table: "Rooms",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "RoomStatus",
                table: "Rooms",
                newName: "Stauts");
        }
    }
}
