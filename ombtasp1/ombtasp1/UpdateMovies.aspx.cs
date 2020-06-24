using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class UpdateMovies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        SqlConnection con = new SqlConnection(@"Data Source = MADHU; Initial Catalog = ombt; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            cmd.Connection = con;
            int mcount = Count() + 1;
            cmd.CommandText = "Insert into dbo.Movie values (@mid ,@mname,@time,@loc,@lan,@sno,@ats)";
            cmd.Parameters.AddWithValue("@mid", mcount);
            cmd.Parameters.AddWithValue("@mname", TxtMName);
            cmd.Parameters.AddWithValue("@time", TxtShowTime);
            cmd.Parameters.AddWithValue("@loc", TxtLocation);
            cmd.Parameters.AddWithValue("@lan", TxtLanguage);
            cmd.Parameters.AddWithValue("@sno", TxtScreenNo);
            cmd.Parameters.AddWithValue("@ats", TxtAvailableTkt);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
            if(count>0)
            {
                Response.Write("Updated Successfully");
                Response.Redirect("AdminDash");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDash");
        }
        protected int Count()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Movie";
            con.Open();
            object count = cmd.ExecuteScalar();
            int cid = Convert.ToInt32(count);
            con.Close();
            return cid;

        }
    }
}