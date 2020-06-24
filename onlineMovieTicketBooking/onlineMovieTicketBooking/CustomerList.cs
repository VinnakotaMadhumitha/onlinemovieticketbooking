using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public  class CustomerList
    {
        List<Customer> customerlist = new List<Customer>();

        public Customer CustomerDetails (int id)
        {
            Customer c = customerlist.Find(a => a.CustomerId == id);

            return c;

        }

        public Boolean LoginCheck(long phno,string pwd)
        {
            Customer c = customerlist.Find(a => a.PhoneNo == phno);
            if (c.Password == pwd)
                return true;
            else
                return false;
            
        }
        public void NewCustomer (Customer c1)
        {
            customerlist.Add(c1);
        }
    }
}
