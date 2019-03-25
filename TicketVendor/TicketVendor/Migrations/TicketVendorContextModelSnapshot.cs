﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketVendor.Data;

namespace TicketVendor.Migrations
{
    [DbContext(typeof(TicketVendorContext))]
    partial class TicketVendorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketVendor.TicketVendor", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Act")
                        .IsRequired();

                    b.Property<double>("Cost");

                    b.Property<DateTime>("Date");

                    b.Property<string>("EventDescription")
                        .IsRequired();

                    b.Property<string>("EventTitle")
                        .IsRequired();

                    b.Property<string>("TicketType")
                        .IsRequired();

                    b.Property<int>("TicketsAvailable");

                    b.Property<string>("Venue")
                        .IsRequired();

                    b.HasKey("TicketID");

                    b.ToTable("Tickets");

                    b.HasData(
                        new { TicketID = 1, Act = "Foals", Cost = 60.0, Date = new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), EventDescription = "Foals live at trinity college 1st June 2019", EventTitle = "Foals: Trinity College", TicketType = "Standing", TicketsAvailable = 5000, Venue = "Trinity College" },
                        new { TicketID = 2, Act = "Vampire Weekend", Cost = 55.0, Date = new DateTime(2019, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), EventDescription = "Vampire Weekend live at trinity college 2nd June 2019", EventTitle = "Foals: Trinity College", TicketType = "Standing", TicketsAvailable = 5000, Venue = "Trinity College" },
                        new { TicketID = 3, Act = "Janelle Monae", Cost = 50.0, Date = new DateTime(2019, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), EventDescription = "Janelle Monae live at trinity college 3rd June 2019", EventTitle = "Janelle Monae: Trinity College", TicketType = "Standing", TicketsAvailable = 5000, Venue = "Trinity College" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
