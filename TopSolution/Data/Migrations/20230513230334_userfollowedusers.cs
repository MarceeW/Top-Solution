using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSolution.Data.Migrations
{
    /// <inheritdoc />
    public partial class userfollowedusers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteUserSiteUser_AspNetUsers_FriendsId",
                table: "SiteUserSiteUser");

            migrationBuilder.RenameColumn(
                name: "FriendsId",
                table: "SiteUserSiteUser",
                newName: "FollowedUsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteUserSiteUser_AspNetUsers_FollowedUsersId",
                table: "SiteUserSiteUser",
                column: "FollowedUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteUserSiteUser_AspNetUsers_FollowedUsersId",
                table: "SiteUserSiteUser");

            migrationBuilder.RenameColumn(
                name: "FollowedUsersId",
                table: "SiteUserSiteUser",
                newName: "FriendsId");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteUserSiteUser_AspNetUsers_FriendsId",
                table: "SiteUserSiteUser",
                column: "FriendsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
