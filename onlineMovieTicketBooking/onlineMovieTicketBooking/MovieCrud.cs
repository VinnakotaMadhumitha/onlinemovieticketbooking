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
    class MovieCrud
    {
        SqlConnection con = null;
         SqlCommand cmd = null;

        DataTable dt = new DataTable();


        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["ombt"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public void ReadData()
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
        public Boolean CreateData(Movie m)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.Movie values (@mid ,@mname,@time,@loc,@lan,@sno,@ats)";
            cmd.Parameters.AddWithValue("@mid",m.MovieId);
            cmd.Parameters.AddWithValue("@mname", m.MovieName);
            cmd.Parameters.AddWithValue("@time", m.ShowTimings);
            cmd.Parameters.AddWithValue("@loc", m.Location);
            cmd.Parameters.AddWithValue("@lan", m.Language);
            cmd.Parameters.AddWithValue("@sno",m.ScreenNo);
            cmd.Parameters.AddWithValue("@ats",m.AvailableTickets);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData(int amt, int mid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Movie set AvailableTickets = @ats where Movie_id = @id";
            cmd.Parameters.AddWithValue("@ats", amt);
            cmd.Parameters.AddWithValue("@id", mid);
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
            cmd.CommandText = " Delete dbo.Movie where Movie_id = @id";
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
            cmd.CommandText = "Select AvailableTickets from dbo.Movie where Movie_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }
        public Object RetriveMovieName(int id)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select Movie_Name from dbo.Movie where Movie_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }
        public Object showTimings (int id)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select showTimings from dbo.Movie where Movie_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }
        public int Count ()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Movie ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int mid = Convert.ToInt32(count);
            return mid;

        }

    }
}

