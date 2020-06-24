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
    class TicketCrud
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
            cmd.CommandText = "select * from dbo.Ticket";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5]);
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean CreateData(Ticket t)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.Ticket values (@tid ,@mname,@mtime,@cid,@not,@amt,@sn)";
            cmd.Parameters.AddWithValue("@tid", t.TicketId);
            cmd.Parameters.AddWithValue("@mname", t.MovieName);
            cmd.Parameters.AddWithValue("@mtime", t.Showtime);
            cmd.Parameters.AddWithValue("@cid", t.CustomerId);
            cmd.Parameters.AddWithValue("@not", t.Not);
            cmd.Parameters.AddWithValue("@amt", t.Amount);
            cmd.Parameters.AddWithValue("@sn", t.SeatNumber);

            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData(double amt,int tid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Ticket set Amount = @amt where Ticket_id = @id";
            cmd.Parameters.AddWithValue("@amt",amt);
            cmd.Parameters.AddWithValue("@id", tid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean DeleteData(int tid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " Delete dbo.Ticket where Ticket_id = @id";
            cmd.Parameters.AddWithValue("@id", tid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean RetriveData(int tid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * from dbo.Ticket where Ticket_id= @id";
            cmd.Parameters.AddWithValue("@id", tid);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5]);
                successFlag = true;
            }
            return successFlag;

        }
        public int Count()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Ticket ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int tid = Convert.ToInt32(count);
            return tid;

        }

        public Boolean CustomerHistory (int id)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Console.WriteLine(id);
            cmd.CommandText = "Select * from dbo.Ticket where Customer_id=  @id ";
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4] + " " + rdr[5]);
                successFlag = true;
            }
            return successFlag;


        }
    }
}
