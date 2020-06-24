using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
  public class Customer
    {
        // Declaring the variables of Customer
        private int _customerId;
        private string _customerName;
        private string _password;
        private double _walletAmt;
        private long _phoneNo;
        private string _address;

        // Parameterised Constructor of Customer

        public Customer(int customerId, string customerName, string password, double walletAmt, long phoneNo, string address)
        {
            _customerId = customerId;
            _customerName = customerName;
            _password = password;
            _walletAmt = walletAmt;
            _phoneNo = phoneNo;
            _address = address;
        }

        
        // Property of  Customer varaiables
        

        public int CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        public double WalletAmt
        {
            get { return this._walletAmt; }
            set { this._walletAmt = value; }
        }
        public long PhoneNo
        {
            get { return this._phoneNo; }
            set { this._phoneNo = value; }
        }
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }
        
    }
}