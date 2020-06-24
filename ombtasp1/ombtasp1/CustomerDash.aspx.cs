using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ombtasp1
{
    public partial class CustomerDash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVm_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMovies");
        }

        protected void btnBt_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookTicket");
        }

        protected void btnVh_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerHistory");
        }

        protected void btnVd_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerDetails");
        }
    }
}