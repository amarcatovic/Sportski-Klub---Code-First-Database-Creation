using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportski_Klub.Migrations
{
    public partial class ClubMediaRelathionFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubMedia_ClubMedia_ClubMediaClubId_ClubMediaMediaId_ClubMediaPublishDate",
                table: "ClubMedia");

            migrationBuilder.DropIndex(
                name: "IX_ClubMedia_ClubMediaClubId_ClubMediaMediaId_ClubMediaPublishDate",
                table: "ClubMedia");

            migrationBuilder.DropColumn(
                name: "ClubMediaClubId",
                table: "ClubMedia");

            migrationBuilder.DropColumn(
                name: "ClubMediaMediaId",
                table: "ClubMedia");

            migrationBuilder.DropColumn(
                name: "ClubMediaPublishDate",
                table: "ClubMedia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubMediaClubId",
                table: "ClubMedia",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClubMediaMediaId",
                table: "ClubMedia",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClubMediaPublishDate",
                table: "ClubMedia",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClubMedia_ClubMediaClubId_ClubMediaMediaId_ClubMediaPublishDate",
                table: "ClubMedia",
                columns: new[] { "ClubMediaClubId", "ClubMediaMediaId", "ClubMediaPublishDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_ClubMedia_ClubMedia_ClubMediaClubId_ClubMediaMediaId_ClubMediaPublishDate",
                table: "ClubMedia",
                columns: new[] { "ClubMediaClubId", "ClubMediaMediaId", "ClubMediaPublishDate" },
                principalTable: "ClubMedia",
                principalColumns: new[] { "ClubId", "MediaId", "PublishDate" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
