using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class usercomments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SiteUserId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_SiteUserId",
                table: "Comments",
                column: "SiteUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_SiteUserId",
                table: "Comments",
                column: "SiteUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_SiteUserId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_SiteUserId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "SiteUserId",
                table: "Comments");
        }
    }
}
