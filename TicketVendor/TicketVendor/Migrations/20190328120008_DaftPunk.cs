using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketVendor.Migrations
{
    public partial class DaftPunk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Act", "Cost", "Date", "EventDescription", "EventTitle", "TicketType", "TicketsAvailable", "Venue" },
                values: new object[] { 5, "Daft Punk", 30.0, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daft Punk live at 3 Arena 20th November 2019", "Daft Punk: 3 Arena", "Standing", 10, "3 Arena" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 5);
        }
    }
}
