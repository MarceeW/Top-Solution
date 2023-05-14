using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class followerproperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Followers",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Followers",
                table: "AspNetUsers");
        }
    }
}
