using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSLibrary.Migrations
{
    public partial class AddTrackInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectAssignedID",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrackNumber",
                table: "Tracks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "inProject",
                table: "Tracks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_ProjectAssignedID",
                table: "Tracks",
                column: "ProjectAssignedID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Projects_ProjectAssignedID",
                table: "Tracks",
                column: "ProjectAssignedID",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Projects_ProjectAssignedID",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_ProjectAssignedID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "ProjectAssignedID",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "TrackNumber",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "inProject",
                table: "Tracks");
        }
    }
}
