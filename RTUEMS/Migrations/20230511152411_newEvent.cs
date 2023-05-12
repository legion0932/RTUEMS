using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RTUEMS.Migrations
{
    /// <inheritdoc />
    public partial class newEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Membertype",
                table: "Event");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Membertype",
                table: "Event",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
