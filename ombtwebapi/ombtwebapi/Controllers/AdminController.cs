using ombtwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ombtwebapi.Controllers
{
    public class AdminController : ApiController
    {
        OmbtContext Oc = new OmbtContext();

        [HttpGet]
        public IEnumerable<Admin> GetAdmins()
        {
            return Oc.Admins.ToList();
        }
        [HttpGet]
        public Admin GetAdmins(int id)
        {
            return Oc.Admins.Find(id);
        }
        [HttpPost]
        public bool AddAdmin(Admin ad)
        {
            bool successflag = false;
            Oc.Admins.Add(ad);
            Oc.SaveChanges();
            successflag = true;
            return successflag;
        }
        [HttpPut]
        public bool UpdateAdmin(Admin ad)
        {
            bool successflag = false;
            var adindb = Oc.Admins.SingleOrDefault(x => x.AdminId == ad.AdminId);
            if (adindb != null)
            {
                adindb.Password = ad.Password;
                adindb.PhoneNo = ad.PhoneNo;
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
        [HttpDelete]
        public bool DeleteAdmin(int id)
        {
            bool successflag = false;
            var adindb = Oc.Admins.SingleOrDefault(x => x.AdminId == id);
            if (adindb != null)
            {
                Oc.Admins.Remove(adindb);
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }

    }
}
