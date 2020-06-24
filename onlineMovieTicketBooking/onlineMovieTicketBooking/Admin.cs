using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineMovieTicketBooking
{
  public  class Admin
    {
        // Declaring the variables of Admin
        private int _adminId;
        private string _adminName;
        private string _password;
        private double _walletAmt;
        private long _phoneNo;

        // Parameterised Constructor of Admin
        public Admin(int adminId, string adminName, string password, double walletAmt, long phoneNo)
        {
            _adminId = adminId;
            _adminName = adminName;
            _password = password;
            _walletAmt = walletAmt;
            _phoneNo = phoneNo;
            
        }

        //Property of Admin varabiles

        public int AdminId
        {
            get { return this._adminId; }
            set { this._adminId = value; }
        }
        public string AdminName
        {
            get { return this._adminName; }
            set { this._adminName = value; }
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
        
    }
}
