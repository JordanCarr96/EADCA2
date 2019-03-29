using System;
using System.Collections.Generic;
using System.Text;

namespace TicketVendorApp
{
    class TicketVendor
    {
        public int TicketID { get; set; }

        public string Act { get; set; }

        public string Venue { get; set; }

        public DateTime Date { get; set; }

        public double Cost { get; set; }

        public string EventTitle { get; set; }

        public string EventDescription { get; set; }

        public string TicketType { get; set; }

        public int TicketsAvailable { get; set; }
    }
}
