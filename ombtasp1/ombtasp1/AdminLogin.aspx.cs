using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source = MADHU; Initial Catalog = ombt; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();

        protected void btnSubmit_Click(object sender, EventArgs e)
        { 
       Boolean successFlag = false;
        cmd = new SqlCommand();
        cmd.Connection = con;
            cmd.CommandText = "Select * from Admin where Admin_phno = @phno and Admin_pwd = @pwd ";
            cmd.Parameters.AddWithValue("@phno", TxtPhno.Text);
            cmd.Parameters.AddWithValue("@pwd", TxtPwd.Text);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                successFlag = true;
            }
           if (successFlag)
            {
                Response.Write("ValidCredentials");
                Response.Redirect("AdminDash");
            }
            else
            {
                Response.Write("Invalid Credentials");
                Response.Redirect("HomePage");
            }
               
            con.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignupAdmin");
        }
    }
}