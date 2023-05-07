using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class topic_hashtag_relatedproglangs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashTags",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelatedProgLanguages",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashTags",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "RelatedProgLanguages",
                table: "Topics");
        }
    }
}
