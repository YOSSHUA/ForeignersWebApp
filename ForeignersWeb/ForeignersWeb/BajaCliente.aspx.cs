using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class BajaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAceptar_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            String correo = Session["mail"].ToString();
            c.bajaCliente(correo);
            Response.Write("<script>alert('se dio de baja');</script>");
        }
    }
}