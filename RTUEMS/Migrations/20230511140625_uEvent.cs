using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RTUEMS.Migrations
{
    /// <inheritdoc />
    public partial class uEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VenueDate",
                table: "Event");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VenueDate",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
