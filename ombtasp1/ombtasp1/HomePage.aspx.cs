using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSc_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignupCustomer");
        }

        protected void btnSa_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpAdmin");
        }

        protected void btnLc_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerLogin");
        }

        protected void btnLa_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin");
        }
    }
}