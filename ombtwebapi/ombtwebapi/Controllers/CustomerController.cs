using ombtwebapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ombtwebapi.Controllers
{
    public class CustomerController : ApiController
    {
        OmbtContext Oc = new OmbtContext();

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return Oc.Customers.ToList();
        }
        [HttpGet]
        public Customer GetCustomer(int id)
        {
            return Oc.Customers.Find(id);
        }
       [HttpPost]
        public bool AddCustomer(Customer cus)
        {
            bool successflag = false;
            Oc.Customers.Add(cus);
            Oc.SaveChanges();
            successflag = true;
            return successflag;
        }
        [HttpPut]
        public bool UpdateCustomer(Customer cus)
        {
            bool successflag = false;
            var cusindb = Oc.Customers.SingleOrDefault(x => x.CustomerId == cus.CustomerId);
            if (cusindb != null)
            {
                cusindb.Password = cus.Password;
                cusindb.PhoneNo = cus.PhoneNo;
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
        [HttpDelete]
        public bool DeleteCustomer(int id)
        {
            bool successflag = false;
            var cusindb = Oc.Customers.SingleOrDefault(x => x.CustomerId == id);
            if (cusindb != null)
            {
                Oc.Customers.Remove(cusindb);
                Oc.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;

        }

    }
 }

