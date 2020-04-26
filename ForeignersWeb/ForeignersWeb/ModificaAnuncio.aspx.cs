
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
                int _idC = Convert.ToInt32(Session["idProp"]);
                c.fillGrid("SELECT * from RegAnuncio WHERE idPropietario =" + Session["idProp"], gvAnun);

            }

        }

        protected void txtID_TextChanged(object sender, EventArgs e)
        {

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
                if (dtpF.SelectedDate.ToString() == "")
                    Response.Write("<script>alert('Elige la nueva fecha de vigencia');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            string query = String.Format("UPDATE RegAuncio SET fechaVig='{0}' WHERE idAnuncio={1}", dtpF.SelectedDate.ToString("dd/MM/yyyy"), txtID.Text);
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se modificó correctamente');</script>");
                            }

                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                    if (txtID.Text == "" || dtpF.SelectedDate.ToString() == "")
                    {
                        Response.Write("<script>alert('Selecciona el anuncio y la fecha de vigencia');</script>");
                    }
                }
            }
        }

        protected void dtpF_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date <= DateTime.Today)
            {
                e.Day.IsSelectable = false;
            }
        }
    }
}