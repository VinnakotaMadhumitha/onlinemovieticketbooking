using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class BookTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = MADHU; Initial Catalog = ombt; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            int ccount = Count() + 1;
            string name = MovieName();
            DateTime time = MovieTime();
            cmd.CommandText = "Insert into dbo.Ticket values (@tid ,@mname,@mtime,@cid,@not,@amt,@sn)";
            cmd.Parameters.AddWithValue("@tid", ccount);
            cmd.Parameters.AddWithValue("@mname", name);
            cmd.Parameters.AddWithValue("@mtime", time);
            cmd.Parameters.AddWithValue("@cid", TxtCId.Text);
            cmd.Parameters.AddWithValue("@not", TxtNOT.Text);
            cmd.Parameters.AddWithValue("@amt", TxtAmt.Text);
            cmd.Parameters.AddWithValue("@sn", TxtSn.Text);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count>0)
            {

                Response.Write("Your Ticket have been Confirmed");
                Response.Redirect("CustomerDash");
            }
            con.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDash");
        }
        protected int Count()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Ticket ";
            con.Open();
            object count = cmd.ExecuteScalar();
            con.Close();
            int cid = Convert.ToInt32(count);
            return cid;
        }
        protected string MovieName ()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select Movie_Name from dbo.Movie where Movie_id=  @id ";
            cmd.Parameters.AddWithValue("@id", TxtMId.Text);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            con.Close();
            string Name = Convert.ToString(walletamount);
            return Name;
        }
        protected DateTime MovieTime ()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select showTimings from dbo.Movie where Movie_id=  @mid ";
            cmd.Parameters.AddWithValue("@mid",TxtMId.Text);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            con.Close();
            DateTime Time = Convert.ToDateTime(walletamount);
            return Time;
        }
    }
}