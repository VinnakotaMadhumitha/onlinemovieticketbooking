using Microsoft.Ajax.Utilities;
using ombtmvc1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ombtmvc1.Controllers
{
        public class AdminController : Controller
        {
           
            OmbtContext ac = new OmbtContext();
            // GET: Admin
            public ActionResult Login()
            {
                return View();
            }
            
        [HttpPost]
        public ActionResult Login(ombtmvc1.Models.Admin admin)
        {
            using (OmbtContext Oc = new OmbtContext())
            {
                Admin adDetails = ac.Admins.SingleOrDefault(a => a.PhoneNo == admin.PhoneNo && a.Password == admin.Password); 
                if (adDetails != null)
                {

                    Session["AdminId"] = adDetails.AdminId;
                    return RedirectToAction("AdminDash", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Phone NUmber or Password is Incorrect!!!");
                }
            }
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
            {
                Admin ad = ac.Admins.Single(cust => cust.AdminId == id);
                return View(ad);

            }

            // GET: Admin/Create
            public ActionResult Create()
            {
                return View();
            }

            // POST: Admin/Create
            [HttpPost]
            public ActionResult Create(Admin a1)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        ac.Admins.Add(a1);
                        ac.SaveChanges();
                        return RedirectToAction("Login");
                    }
                    return View();


                }
                catch
                {
                    return View();
                }
            }

            // GET: Admin/Edit/5
            public ActionResult Edit(int id)
            {

                Admin ad = ac.Admins.Single(cust => cust.AdminId == id);
                return View(ad);


            }

            // POST: Admin/Edit/5
            [HttpPost]
            public ActionResult Edit(int id, Admin a1)
            {
                try
                {
                    if (ModelState.IsValid)
                    {
                        ac.Admins.AddOrUpdate(a1);
                        ac.SaveChanges();
                        return RedirectToAction("Login");
                    }
                    return View();



                }
                catch
                {
                    return View();
                }
            }
        public ActionResult AdminDash()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
        }
    }