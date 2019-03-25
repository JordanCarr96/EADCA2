using System;
using System.ComponentModel.DataAnnotations;


namespace TicketVendor
{
    public class TicketVendor
    {
        [Key]
        public int TicketID { get; set; }

        [Required]
        public string Act { get; set; }

        [Required]
        public string Venue { get; set; }

        [Required]
        public  DateTime Date { get; set; }

        [Required]
        public double Cost { get; set; }

        [Required]
        public string EventTitle { get; set; }

        [Required]
        public string EventDescription { get; set; }

        [Required]
        public string TicketType { get; set; }

        [Required]
        public int TicketsAvailable { get; set; }


    }
}
