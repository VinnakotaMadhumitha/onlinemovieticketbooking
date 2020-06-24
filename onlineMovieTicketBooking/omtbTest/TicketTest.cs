using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using onlineMovieTicketBooking;

namespace omtbTest
{
    
    public class TicketTest
    {
        Ticket t1 = new Ticket(1, "abc", new DateTime(2020, 06, 01), 1, 2, 200, 24);
        TicketList tlt = new TicketList();
       
        [TestCase(1)]
        public void TestCustomerHistory (int id)
        {
            Ticket tt = tlt.CustomerHistory(id);
            Assert.AreNotEqual(t1, tt);
        }
        [Test]
        public void TestTicket ()
        {
            Assert.AreEqual(1, t1.TicketId);
            Assert.AreEqual("abc",t1.MovieName);
            Assert.AreEqual(1, t1.CustomerId);
            Assert.AreEqual(2,t1.Not);
            Assert.AreEqual(200, t1.Amount);
            Assert.AreEqual(24, t1.SeatNumber);
        }
    }
}
