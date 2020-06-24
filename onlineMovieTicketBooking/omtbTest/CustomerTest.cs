using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using onlineMovieTicketBooking;
using System.Security.AccessControl;

namespace omtbTest
{
    public class CustomerTest 
    {

        Customer c1 = new Customer(1, "Madhumitha", "M@dhu", 1000, 7989933656, "abc");
        Program pc = new Program();
        CustomerList clt = new CustomerList();

        [Test]
        public  void TotalamountTest ()
        {
           
            Assert.AreEqual(200, pc.Totalamount(2));

        }
        [SetUp]
        public void CustomerSetup()
        {
            Customer c = new Customer(1, "Madhumitha", "M@dhu", 1000, 7989933656, "abc");
            clt.NewCustomer(c);
        }

        [Test]

        public void TestCustomer ()
        {
            //pc.CustomerLogin();
            
            Assert.AreEqual(1, c1.CustomerId);

            Assert.AreEqual("Madhumitha", c1.CustomerName);
            Assert.AreEqual("M@dhu", c1.Password);
            Assert.AreEqual(7989933656, c1.PhoneNo);
            Assert.AreEqual("abc", c1.Address);
            Assert.AreEqual(1000, c1.WalletAmt);
            
        }
        [TestCase(1)]
         public void TestCustomerInfo(int id)
        {
            Customer ct = clt.CustomerDetails( id);
            Assert.AreNotEqual(c1, ct);
        }
      [TestCase(7989933656,"M@dhu")]
      public void  TestLoginCheck(long phno, string pwd)
        {
            bool result = clt.LoginCheck(phno, pwd);
            Assert.IsTrue(result);
        }

    }
}
