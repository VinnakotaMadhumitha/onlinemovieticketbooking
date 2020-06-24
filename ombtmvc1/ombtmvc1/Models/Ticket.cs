using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ombtmvc1.Models
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public string SeatNo { get; set; }
        public int CustomerId { get; set; }
        public DateTime ShowTime { get; set; }
        public int NoOfTickets { get; set; }
        public double Amnt { get; set; }
        public int MovieId { get; set; }
        public string Location { get; set; }

    }
}