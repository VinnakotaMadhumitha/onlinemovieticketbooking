using ombtmvc1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Deployment.Internal;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ombtmvc1.Controllers
{
    public class CartController : Controller
    {
        Customer c = new Customer();
        OmbtContext c1 = new OmbtContext();

        public ActionResult CartDetails()
        {
            string cphno = Session["CustomerPhno"].ToString();
            var c = c1.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            var item = c1.Carts.Where(a => a.CustomerId == c.CustomerId).ToList();
            return View(item);
        }

        public ActionResult cartEmpty()
        {
            TempData["cartEmpty"] = "Empty Cart";
            return View();
        }
        [HttpGet]
        public ActionResult proceed(Cart cart)
        {

            string cphno = Session["CustomerPhno"].ToString();
            var c = c1.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            var Cartlist = c1.Carts.Where(a => a.CustomerId == c.CustomerId).ToList();
            if (Cartlist.Count == 0)
            {
                double Total = 0;
                TempData["Total"] = Convert.ToString(Total);
                return RedirectToAction("cartEmpty", "CartT");
                
            }
            else
            {
                double Total = Cartlist.Sum(i => i.Amnt);
                TempData["Total"] = Convert.ToString(Total);

                return View(Cartlist);
            }
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cdel = c1.Carts.Find(id);
            if(cdel == null)
            {
                return HttpNotFound();
            }
            return View(cdel);
        }
        [HttpPost]
        public ActionResult Delete (int id)
        {
            Cart cdel = c1.Carts.Find(id);
            c1.Carts.Remove(cdel);
            c1.SaveChanges();
            return RedirectToAction("CartDetails");

        }
       public ActionResult Payment()
        {

            string cphno = Session["CustomerPhno"].ToString();
            var customer1 = c1.Customers.Where(cust => cust.PhoneNo == cphno).FirstOrDefault();
            var Cartlist = c1.Carts.Where(a => a.CustomerId == customer1.CustomerId).ToList();
            foreach (var item in Cartlist)
            {
                int AId = 1;
                var movie = c1.Movies.Where(a => a.Movie_Id == item.MovieId).FirstOrDefault();
                c1.Tickets.Add(new Ticket { MovieName = item.MovieName, SeatNo = item.SeatNo, CustomerId = item.CustomerId, ShowTime = movie.Movie_time, Amnt = 100, NoOfTickets = 1, MovieId = item.MovieId, Location = movie.Movie_location });
                movie.Atickets = movie.Atickets - 1;
                c1.Movies.AddOrUpdate(movie);
                var admin = c1.Admins.Where(b => b.AdminId == AId).FirstOrDefault();
                admin.WalletAmnt = admin.WalletAmnt + 100;
                c1.Admins.AddOrUpdate(admin);
                var customer = c1.Customers.Where(c => c.CustomerId == item.CustomerId).FirstOrDefault();
                customer.WalletAmnt = customer.WalletAmnt - 100;
                c1.Customers.AddOrUpdate(customer);
                var cart = c1.Carts.Where(d => d.CartId == item.CartId).FirstOrDefault();
                c1.Carts.Remove(cart);
                c1.SaveChanges();
            }
                return View();
        }
    }
}