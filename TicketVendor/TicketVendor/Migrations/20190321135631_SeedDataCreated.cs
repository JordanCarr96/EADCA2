using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketVendor.Migrations
{
    public partial class SeedDataCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketVendors",
                table: "TicketVendors");

            migrationBuilder.RenameTable(
                name: "TicketVendors",
                newName: "Tickets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "TicketID");

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Act", "Cost", "Date", "EventDescription", "EventTitle", "TicketType", "TicketsAvailable", "Venue" },
                values: new object[] { 1, "Foals", 60.0, new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Foals live at trinity college 1st June 2019", "Foals: Trinity College", "Standing", 5000, "Trinity College" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Act", "Cost", "Date", "EventDescription", "EventTitle", "TicketType", "TicketsAvailable", "Venue" },
                values: new object[] { 2, "Vampire Weekend", 55.0, new DateTime(2019, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vampire Weekend live at trinity college 2nd June 2019", "Foals: Trinity College", "Standing", 5000, "Trinity College" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketID", "Act", "Cost", "Date", "EventDescription", "EventTitle", "TicketType", "TicketsAvailable", "Venue" },
                values: new object[] { 3, "Janelle Monae", 50.0, new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janelle Monae live at trinity college 3rd June 2019", "Janelle Monae: Trinity College", "Standing", 5000, "Trinity College" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "TicketVendors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketVendors",
                table: "TicketVendors",
                column: "TicketID");
        }
    }
}
