using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CSLibrary.Migrations
{
    public partial class UpdateProjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ConvertedPicture",
                table: "Projects",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConvertedPicture",
                table: "Projects");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Picture",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
