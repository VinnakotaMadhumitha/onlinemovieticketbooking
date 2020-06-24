using ombtmvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ombtmvc1.Controllers
{
    public class CustomerController : Controller
    {
        OmbtContext custContext = new OmbtContext();
        public ActionResult CustomerName()
        {
           
            List<Customer> c2 = custContext.Customers.ToList();
            return View(c2);
        }


        public ActionResult Details(int id)
        {
            Customer c1 = custContext.Customers.Single(cust => cust.CustomerId == id);
            return View(c1);
        }
        [HttpGet]
        public ActionResult CustomerSignup()
        {
            //CustomerContext c2 = new CustomerContext();
            return View();
        }
        [HttpPost]
        public ActionResult CustomerSignup(Customer customer)
        {
            if (ModelState.IsValid)
            {
                custContext.Customers.Add(customer);
                custContext.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(ombtmvc1.Models.Customer customer)
        {
            using (OmbtContext Oc = new OmbtContext())
            {
                Customer cuDetails = Oc.Customers.SingleOrDefault(a => a.PhoneNo == customer.PhoneNo && a.Password == customer.Password);
                if(cuDetails!=null)
                {

                    Session["CustomerPhno"] = cuDetails.PhoneNo;
                    return RedirectToAction("MovieList", "Movie");
                }
                else
                {
                    ModelState.AddModelError("","Phone NUmber or Password is Incorrect!!!");
                }
            }
            return View();
        }
        public ActionResult CustomerDash()
        {
            return View();
        }
    }
}

