using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace onlineMovieTicketBooking
{
    class CustomerCrud
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["ombt"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public Boolean ReadData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from dbo.Customer";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5]);
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean CreateData(Customer c)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.customer values (@cid ,@cname,@pwd,@cwamt,@phno,@add)";
            cmd.Parameters.AddWithValue("@cid", c.CustomerId);
            cmd.Parameters.AddWithValue("@cname",c.CustomerName);
            cmd.Parameters.AddWithValue("@pwd", c.Password);
            cmd.Parameters.AddWithValue("@cwamt",c.WalletAmt);
            cmd.Parameters.AddWithValue("@phno", c.PhoneNo);
            cmd.Parameters.AddWithValue("@add", c.Address);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData(double amt,int cid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Customer set Wallet_amt = @amt where Customer_id = @id";
            cmd.Parameters.AddWithValue("@amt", amt);
            cmd.Parameters.AddWithValue("@id", cid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean DeleteData(int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " Delete dbo.Customer where Customer_id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Object RetriveData(int id)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Console.WriteLine(id);
            cmd.CommandText = "Select Wallet_amt from dbo.Customer where Customer_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }
        public Boolean CustomerData(int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from dbo.Customer where Customer_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CustomerId : " + rdr[0] + "CustomerName :  " + rdr[1] + " Password : " + rdr[2] + "Walletamt : " + rdr[3] + "Phoneno : " + rdr[4] + "Address : " + rdr[5]);
                Console.ResetColor();
                successFlag = true;
            }
            return successFlag;


        }
        public int Count()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Customer ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int cid = Convert.ToInt32(count);
            return cid;

        }
        public Boolean LoginCheck(long phno,string pwd)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Customer where Customer_phno = @phno and Customer_pwd = @pwd ";
            cmd.Parameters.AddWithValue("@phno", phno);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                successFlag = true;
            }
            return successFlag;


        }
    }

    }

