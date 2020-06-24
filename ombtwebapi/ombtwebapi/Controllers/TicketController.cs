using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ombtwebapi.Models;

namespace ombtwebapi.Controllers
{
    public class TicketController : ApiController
    {
        OmbtContext Oc = new OmbtContext();

        [HttpGet]
        public IEnumerable<Ticket> GetTickets()
        {
            return Oc.Tickets.ToList();
        }
        [HttpGet]
        public Ticket GetTicket (int id)
        {
            return Oc.Tickets.Find(id);
        }
        [HttpPost]
        public bool AddTicket(Ticket t)
        {
            bool successflag = false;
            Oc.Tickets.Add(t);
            Oc.SaveChanges();
            successflag = true;
            return successflag;
        }
        [HttpPut]
        public bool UpdateTicket(Ticket t)
        {
            bool successflag = false;
            var tindb = Oc.Tickets.SingleOrDefault(x => x.TicketId == t.TicketId);
            if (tindb != null)
            {
                tindb.Amnt = t.Amnt;
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
        [HttpDelete]
        public bool DeleteTicket(int id)
        {
            bool successflag = false;
            var tindb = Oc.Tickets.SingleOrDefault(x => x.TicketId == id);
            if (tindb != null)
            {
                Oc.Tickets.Remove(tindb);
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
    }
}


