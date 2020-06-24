using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
   public class AdminList
    {
        List<Admin> adminlist = new List<Admin>();
        public bool ALoginCheck(long phno, string pwd)
        {
            Admin  a1 = adminlist.Find(a => a.PhoneNo == phno);
            if (a1.Password == pwd)
                return true;
            else
                return false;

        }
        public void NewAdmin(Admin a)
        {
            adminlist.Add(a);
        }
    }
}
