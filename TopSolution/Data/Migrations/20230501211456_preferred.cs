using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class preferred : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrefferedLanguages",
                table: "AspNetUsers",
                newName: "PreferredLanguages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PreferredLanguages",
                table: "AspNetUsers",
                newName: "PrefferedLanguages");
        }
    }
}
