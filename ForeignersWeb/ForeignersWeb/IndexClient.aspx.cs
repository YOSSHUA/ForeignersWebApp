using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["type"] == null || Session["idProp"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void lkBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mapa.aspx");
        }

        protected void lkBtnAltaRenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaRenta.aspx");
        }

        protected void lkBtnAltaCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaCliente.aspx");
        }

        protected void lkBajaAnuncio_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaAnuncio.aspx");
        }

        protected void lkBajaCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaCliente.aspx");
        }

        protected void lkBtnAltaEst_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaEstablecimiento.aspx");
        }

        protected void lkBtnAltaAnuncio_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaAnuncio.aspx");
        }
    }
}