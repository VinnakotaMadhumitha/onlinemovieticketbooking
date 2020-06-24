using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dbconnect
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
        public Boolean CreateData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.admin values (4,'Rama','Rama',2000,'7386018900')";
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Admin set Wallet_amt = 3000 where Admin_id =1";
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean DeleteData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " Delete dbo.Admin where Admin_id = 3";
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Object RetriveData()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Wallet_amt from dbo.Admin where Admin_id=1";
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }

    }
}
