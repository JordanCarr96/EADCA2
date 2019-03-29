using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketVendor.Migrations
{
    public partial class coldplay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Act", "Cost", "Date", "EventDescription", "EventTitle", "TicketType", "TicketsAvailable", "Venue" },
                values: new object[] { 4, "Coldplay", 50.0, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coldplay live at 3 Arena 20th November 2019", "Coldplay: 3 Arena", "Standing", 0, "3 Arena" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 4);
        }
    }
}
