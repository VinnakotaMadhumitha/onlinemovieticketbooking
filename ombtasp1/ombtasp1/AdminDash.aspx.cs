using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class AdminDash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVcs_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCustomers");
        }

        protected void btnVbh_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBookings");
        }

        protected void btnUm_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateMovies");
        }
    }
}