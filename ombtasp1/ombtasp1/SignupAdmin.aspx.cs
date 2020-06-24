using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class SignupAdmin : System.Web.UI.Page
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
            cmd.CommandText = "Insert into dbo.admin values (@aid ,@aname,@pwd,@awamt,@phno)";
            cmd.Parameters.AddWithValue("@aid", ccount);
            cmd.Parameters.AddWithValue("@aname", TxtName.Text);
            cmd.Parameters.AddWithValue("@pwd",TxtPwd.Text);
            cmd.Parameters.AddWithValue("@awamt", Txtamt.Text);
            cmd.Parameters.AddWithValue("@phno", TxtPhno.Text);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            con.Close();
         if (count>0)
            {
                Response.Redirect("AdminLogin");
            }

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage");

        }
        protected int Count()
        {
            cmd.Connection = con;
            cmd.CommandText = "Select count(*)from dbo.Admin ";
            con.Open();
            object count = cmd.ExecuteScalar();
            con.Close();
            int cid = Convert.ToInt32(count);
            return cid;
        }
    }
}