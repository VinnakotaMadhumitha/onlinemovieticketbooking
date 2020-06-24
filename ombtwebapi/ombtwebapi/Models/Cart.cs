using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ombtwebapi.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public string MovieName { get; set; }
        public string SeatNo { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public double Amnt { get; set; }
        public int MovieId { get; set; }

    }
}