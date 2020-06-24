
using ombtmvc1.Models;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ombtmvc1.Controllers
{
    public class TicketController : Controller
    {
        OmbtContext Tc = new OmbtContext();
        Customer c = new Customer();
        int count = 1;
        bool flag = true;
      //  Ticket t = new Ticket();
        [HttpGet]
        public ActionResult BookNow(int id)
        {
            string cphno = Session["CustomerPhno"].ToString();
            var customer = Tc.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            Ticket t = new Ticket();
            var item = Tc.Movies.Where(a => a.Movie_Id == id).FirstOrDefault();
            t.MovieName = item.Movie_Name;
            t.ShowTime = item.Movie_time;
            t.Location = item.Movie_location;
            t.MovieId = item.Movie_Id;
            t.CustomerId = customer.CustomerId;
            string mid = Convert.ToString(t.MovieId);
            return View(t);
        }
        [HttpPost]
        public ActionResult BookNow(Ticket t)
        {
            string cphno = Session["CustomerPhno"].ToString();
            var customer = Tc.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            List<Ticket> booking = new List<Ticket>();
            List<Cart> carts = new List<Cart>();
            string seatno = t.SeatNo.ToString();
            int movieId = t.MovieId;
            var item1 = Tc.Movies.Where(a => a.Movie_Id == movieId).FirstOrDefault();
            string moviename = item1.Movie_Name;
            string[] seatnoArray = seatno.Split(',');
            count = seatnoArray.Length;
            if (Checkseat(seatno, movieId) == false)
            {
                foreach (var item in seatnoArray)
                {
                    carts.Add(new Cart { Amnt = 100, CustomerId =customer.CustomerId, MovieId = t.MovieId, Date = Convert.ToDateTime(item1.Movie_time), MovieName = moviename, SeatNo = item });
                }
                foreach (var item in carts)
                {
                   // CartContext c2 = new CartContext();
                    Tc.Carts.Add(item);
                   Tc.SaveChanges();
                }
                TempData["Success"] = "Seat number Booked,Check your Cart";
            }
            else
            {
                TempData["seatnomsg"] = "please change your seat number";
            }
            return RedirectToAction("BookNow");

        }

        private bool Checkseat(string seatno, int movieId)
        {
            //throw new NotImplementedException();
            string seats = seatno;
            string[] seatreserve = seats.Split(',');
            var seatnolist = Tc.Tickets.Where(a => a.MovieId == movieId).ToList();
            foreach (var item in seatnolist)
            {
                string alreadyBook = item.SeatNo;
                foreach (var item1 in seatreserve)
                {
                    if (item1 == alreadyBook)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag == false)
                return true;
            else
                return false;
        }
        [HttpPost]
        public ActionResult Checkseat(Ticket ticket, DateTime date)
        {
            string seatno = string.Empty;
            var m1 = Tc.Tickets.Where(a => a.ShowTime == date).ToList();
            if (m1 != null)
            {
                var getseatno = m1.Where(b => b.MovieId == ticket.MovieId).ToList();
                if (getseatno != null)
                {
                    foreach (var item in getseatno)
                    {
                        seatno = seatno + " " + item.SeatNo.ToString();
                    }
                    TempData["SNO"] = "Already Booked" + seatno;
                }

            }
            return View();
        }
        public ActionResult Qrcode()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Qrcode(string InputText)
        {
            string cphno = Session["CustomerPhno"].ToString();
            var customer = Tc.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            int custId = customer.CustomerId;
            var book = Tc.Tickets.Where(ti => ti.CustomerId == custId).FirstOrDefault();
            int tid = book.TicketId;
            int cid = book.CustomerId;
            double amt = book.Amnt;
            int mid = book.MovieId;
            string mnam = book.MovieName;
            int not = book.NoOfTickets;
            string loc = book.Location;
            string seat = book.SeatNo;
            DateTime dt = book.ShowTime;
            var qr = tid + "\n" + cid + "\n" + mid + "\n" + mnam + "\n" + not + "\n" + loc + "\n" + seat + "\n" + dt;
            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator oQRCodeGenerator = new QRCodeGenerator();
                QRCodeData oQRCodeData = oQRCodeGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                QRCode oQRCode = new QRCode(oQRCodeData);
                using (Bitmap oBitmap = oQRCode.GetGraphic(20))
                {
                    oBitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCode = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }
            }
            return View();
        }


    }
}