using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventRegistrationSystem.Data.Migrations
{
    public partial class Ver12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "TimeOfEnd",
                table: "Performance",
                type: "time",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "EmailAddress", "Name", "NumberOfMembers" },
                values: new object[,]
                {
                    { 1, "arch@enemy.com", "Arch Enemy", 5 },
                    { 2, "soad@rock.com", "System Of A Down", 4 },
                    { 3, "metallica@mail.com", "Metallica", 4 },
                    { 4, "lumen@mail.ru", "Lumen", 5 },
                    { 5, "slot@mail.ru", "Slot", 5 },
                    { 6, "kazka@mail.ua", "KAZKA", 3 }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Some description", "Coachella" },
                    { 2, new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lollapalooza is a 4-Day music festival happening August 3-6, 2023 at historic Grant Park in Chicago, Illinois, USA.", "Lollapalooza" },
                    { 3, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock in Rio is a recurring music festival originating in Rio de Janeiro, Brazil. It later branched into other locations such as Lisbon, Madrid and Las Vegas.", "Rock in Rio" },
                    { 4, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomorrowland is a large-scale annual electronic dance music festival held at De Schorre provincial recreational park in Boom, Antwerp Province, Belgium.", "Tomorrowland" }
                });

            migrationBuilder.InsertData(
                table: "Performance",
                columns: new[] { "Id", "ArtistId", "EventId", "QueuePosition", "TimeOfEnd", "TimeOfStart" },
                values: new object[,]
                {
                    { 1, 1, 3, 1, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0) },
                    { 2, 2, 3, 2, null, new TimeSpan(0, 17, 0, 0, 0) },
                    { 3, 6, 2, 1, null, new TimeSpan(0, 19, 30, 0, 0) },
                    { 4, 5, 4, 2, null, new TimeSpan(0, 19, 40, 0, 0) },
                    { 5, 1, 1, 1, null, new TimeSpan(0, 16, 0, 0, 0) },
                    { 6, 3, 1, 2, null, new TimeSpan(0, 17, 0, 0, 0) },
                    { 7, 2, 1, 3, null, new TimeSpan(0, 20, 0, 0, 0) },
                    { 8, 4, 1, 4, null, new TimeSpan(0, 20, 45, 0, 0) },
                    { 9, 3, 3, 3, null, new TimeSpan(0, 21, 38, 0, 0) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Performance",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artist",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "TimeOfEnd",
                table: "Performance");
        }
    }
}
