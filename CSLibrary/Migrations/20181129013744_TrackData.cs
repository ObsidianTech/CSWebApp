using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSLibrary.Migrations
{
    public partial class TrackData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfUpload",
                table: "Tracks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Tracks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TrackFile",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrackName",
                table: "Tracks",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isMP3",
                table: "Tracks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isStems",
                table: "Tracks",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isWAV",
                table: "Tracks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfUpload",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "TrackFile",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "TrackName",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "isMP3",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "isStems",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "isWAV",
                table: "Tracks");
        }
    }
}
