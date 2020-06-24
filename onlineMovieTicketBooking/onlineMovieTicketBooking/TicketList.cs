using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public class TicketList
    {
        List<Ticket> ticketlist = new List<Ticket>();

        public Ticket CustomerHistory (int id)
        {
             Ticket t = ticketlist.Find(a => a.CustomerId == id);

            return t;

        }
        public void BookingHistory ()
        {
            foreach (Ticket t1 in ticketlist)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Id = {0}, MovieName = {1}, Timings = {2}, customerId = {3}, Number of Tickets = {4},AAmount = {5}, Seat Number {6}", t1.TicketId, t1.MovieName, t1.Showtime, t1.CustomerId, t1.Not, t1.Amount, t1.SeatNumber);
                Console.ResetColor();
            }
        
        }
        public Ticket TicketCancellation (int tid)
        {
            Ticket t1 = ticketlist.Find(a => a.TicketId == tid);
            return t1;
        }
        public void NewTicket (Ticket t)
        {
            ticketlist.Add(t);
        }
    }
}
