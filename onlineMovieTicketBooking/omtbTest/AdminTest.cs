using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using onlineMovieTicketBooking;

namespace omtbTest
{
  
    public class AdminTest

    {
        AdminList alt = new AdminList();
        [SetUp]
        public void AdminSetup()
        {
            Admin a1 = new Admin(1, "admin", "23456", 1000, 7989933656);
            alt.NewAdmin(a1);
        }
       
      

      [Test]
      public void When_passwordsatisfies_expects_true ()
        {
            bool result = alt.ALoginCheck(7989933656,"madhu");
            Assert.IsFalse(result);
        }
    }
}
