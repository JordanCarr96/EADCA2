using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TicketVendor.Data
{
    public class TicketVendorContext : DbContext

    {

        public DbSet<TicketVendor> Tickets { get; set; }


        public TicketVendorContext(DbContextOptions<TicketVendorContext> options)
    : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketVendor>()
                .HasKey(t => t.TicketID);

            modelBuilder.Entity<TicketVendor>().HasData(new TicketVendor
            {
                TicketID = 1,
                Act = "Foals",
                Venue = "Trinity College",
                Date = new DateTime(2019, 06, 01),
                Cost = 60,
                EventTitle = "Foals: Trinity College",
                EventDescription = "Foals live at trinity college 1st June 2019",
                TicketType = "Standing",
                TicketsAvailable = 5000
            },
           new TicketVendor
           {
               TicketID = 2,
               Act = "Vampire Weekend",
               Venue = "Trinity College",
               Date = new DateTime(2019, 06, 02),
               Cost = 55,
               EventTitle = "Foals: Trinity College",
               EventDescription = "Vampire Weekend live at trinity college 2nd June 2019",
               TicketType = "Standing",
               TicketsAvailable = 5000
           },

           new TicketVendor
           {
               TicketID = 3,
               Act = "Janelle Monae",
               Venue = "Trinity College",
               Date = new DateTime(2019, 06, 03),
               Cost = 50,
               EventTitle = "Janelle Monae: Trinity College",
               EventDescription = "Janelle Monae live at trinity college 3rd June 2019",
               TicketType = "Standing",
               TicketsAvailable = 5000

           });
        }



    }
}

