using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaaPinden.Migrations
{
    /// <inheritdoc />
    public partial class AddedLikeAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pinds_AspNetUsers_ApplicationUserId",
                table: "Pinds");

            migrationBuilder.DropColumn(
                name: "Like",
                table: "Pinds");

            migrationBuilder.CreateTable(
                name: "PindLikes",
                columns: table => new
                {
                    LikedById = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LikedPindsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PindLikes", x => new { x.LikedById, x.LikedPindsId });
                    table.ForeignKey(
                        name: "FK_PindLikes_AspNetUsers_LikedById",
                        column: x => x.LikedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PindLikes_Pinds_LikedPindsId",
                        column: x => x.LikedPindsId,
                        principalTable: "Pinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PindLikes_LikedPindsId",
                table: "PindLikes",
                column: "LikedPindsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pinds_AspNetUsers_ApplicationUserId",
                table: "Pinds",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pinds_AspNetUsers_ApplicationUserId",
                table: "Pinds");

            migrationBuilder.DropTable(
                name: "PindLikes");

            migrationBuilder.AddColumn<int>(
                name: "Like",
                table: "Pinds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Pinds_AspNetUsers_ApplicationUserId",
                table: "Pinds",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
