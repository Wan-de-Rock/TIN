using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Data.Migrations
{
    public partial class Ver_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Performance_ArtistId",
                table: "Performance");

            migrationBuilder.DropIndex(
                name: "IX_Performance_EventId",
                table: "Performance");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Event",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artist",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performance_ArtistId",
                table: "Performance",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_EventId",
                table: "Performance",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Performance_ArtistId",
                table: "Performance");

            migrationBuilder.DropIndex(
                name: "IX_Performance_EventId",
                table: "Performance");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Event",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Event",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Performance_ArtistId",
                table: "Performance",
                column: "ArtistId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performance_EventId",
                table: "Performance",
                column: "EventId",
                unique: true);
        }
    }
}
