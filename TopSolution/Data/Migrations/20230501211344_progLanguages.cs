using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class progLanguages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrefferedLanguages",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrefferedLanguages",
                table: "AspNetUsers");
        }
    }
}
