using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaaPinden.Migrations
{
    /// <inheritdoc />
    public partial class initJeppe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MediaType",
                table: "Pinds");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Pinds");

            migrationBuilder.AddColumn<string>(
                name: "MediaPath",
                table: "Pinds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");   

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pinds",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pinds");

            migrationBuilder.DropColumn(
                name: "MediaPath",
                table: "Pinds");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Pinds",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "MediaType",
                table: "Pinds",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }
    }
}
