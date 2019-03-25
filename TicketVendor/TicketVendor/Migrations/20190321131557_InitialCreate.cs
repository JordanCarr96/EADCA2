using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicketVendor.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TicketVendors",
                columns: table => new
                {
                    TicketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Act = table.Column<string>(nullable: false),
                    Venue = table.Column<string>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    EventTitle = table.Column<string>(nullable: false),
                    EventDescription = table.Column<string>(nullable: false),
                    TicketType = table.Column<string>(nullable: false),
                    TicketsAvailable = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketVendors", x => x.TicketID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TicketVendors");
        }
    }
}
