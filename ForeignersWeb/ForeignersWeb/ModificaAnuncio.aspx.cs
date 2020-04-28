
using ForeignersWeb.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class ModificaAnuncio : System.Web.UI.Page
    {
        protected DateTime maxDate;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idProp"] == null)
                Response.Redirect("Login.aspx");
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
                int _idC = Convert.ToInt32(Session["idProp"]);
                c.fillGrid("SELECT * from RegAnuncio WHERE idCliente =" + Session["idProp"], gvAnun);

            }

        }

        public void updateGrid()
        {
            Conexion c = new Conexion();
            try
            {
                c.fillGrid("SELECT * from RegAnuncio WHERE idPropietario =" + Session["idProp"], gvAnun);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hubo un error: " + ex.ToString() + "');</script>");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                Response.Write("<script>alert('Selecciona un anuncio');</script>");
            }
            else
            {
                if (dtpVigencia.SelectedDate.ToString() == "")
                    Response.Write("<script>alert('Elige la nueva fecha de vigencia');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                    {
                        try
                        {
                            string query = String.Format("UPDATE RegAnuncio SET fechaVig='{0}' WHERE idAnuncio={1}", dtpVigencia.SelectedDate.ToString("dd/MM/yyyy"), txtID.Text);
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se modificó correctamente');</script>");
                                c.fillGrid("SELECT * from RegAnuncio WHERE idCliente =" + Session["idProp"], gvAnun);
                            }

                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                    }
                }
            }
        }

        protected void dtpF_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date <= Convert.ToDateTime(Session["minDate"]))
            {
                e.Day.IsSelectable = false;
            }
        }

        protected void gvAnun_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = HttpUtility.HtmlDecode(gvAnun.SelectedRow.Cells[1].Text);
            dtpVigencia.Enabled = true;
            Session["minDate"] = Convert.ToDateTime(HttpUtility.HtmlDecode(gvAnun.SelectedRow.Cells[3].Text));

        }
    }
}