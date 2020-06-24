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
    class AdminCrud
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
            cmd.CommandText = "select * from dbo.Admin";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4]);
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean CreateData(Admin a)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.admin values (@aid ,@aname,@pwd,@awamt,@phno)";
            cmd.Parameters.AddWithValue("@aid",a.AdminId);
            cmd.Parameters.AddWithValue("@aname", a.AdminName);
            cmd.Parameters.AddWithValue("@pwd", a.Password);
            cmd.Parameters.AddWithValue("@awamt", a.WalletAmt);
            cmd.Parameters.AddWithValue("@phno", a.PhoneNo);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData(double amt, int aid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Admin set Wallet_amt = @amt where Admin_id = @id";
            cmd.Parameters.AddWithValue("@amt", amt);
            cmd.Parameters.AddWithValue("@id", aid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean DeleteData( int aid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " Delete dbo.Admin where Admin_id = @id";
            cmd.Parameters.AddWithValue("@id", aid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Object RetriveData(int aid)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Wallet_amt from dbo.Admin where Admin_id= @id";
            cmd.Parameters.AddWithValue("@id", aid);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }

        public int Count()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Admin ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int aid = Convert.ToInt32(count);
            return aid;

        }
        public Boolean LoginCheck(long phno, string pwd)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from Admin where Admin_phno = @phno and Admin_pwd = @pwd ";
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
