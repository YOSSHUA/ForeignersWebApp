using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class IndexStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["mail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

     

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaAlumno.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificaAlumno.aspx");
        }
    }
}