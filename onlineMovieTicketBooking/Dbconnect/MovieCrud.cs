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
    class MovieCrud
    {
        SqlConnection con = null;
       // SqlCommand cmd = null;
        
        DataTable dt = new DataTable();
        

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["ombt"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public void ReadData ()
        {
            string cs = ConfigurationManager.ConnectionStrings["ombt"].ConnectionString;
            SqlDataAdapter sda = new SqlDataAdapter("select * from dbo.Movie", cs);
           // DataSet ds = new DataSet();
           // DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow rdr in dt.Rows)
            {

                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5] + " " + rdr[6]);

            }
            Console.WriteLine("disconnected");
        }
        public void CreateData ()
        {
            DataSet ds = new DataSet();
            string cs = ConfigurationManager.ConnectionStrings["ombt"].ConnectionString;
        SqlDataAdapter sda = new SqlDataAdapter(" insert into dbo.Movie values (4,'abcd','2020-06-10 10:30:00','vizag','Telugu',1,21)", cs);
            sda.Update(ds,"dbo.Movie");
            Console.Write("Data updated suceesfully");
        }
    }
}
