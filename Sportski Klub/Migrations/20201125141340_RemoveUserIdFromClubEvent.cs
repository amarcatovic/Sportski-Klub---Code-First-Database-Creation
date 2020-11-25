using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportski_Klub.Migrations
{
    public partial class RemoveUserIdFromClubEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventClub_User_UserId",
                table: "EventClub");

            migrationBuilder.DropIndex(
                name: "IX_EventClub_UserId",
                table: "EventClub");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EventClub");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EventClub",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventClub_UserId",
                table: "EventClub",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventClub_User_UserId",
                table: "EventClub",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
