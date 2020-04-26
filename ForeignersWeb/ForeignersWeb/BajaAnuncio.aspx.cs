using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class BajaAnuncio : System.Web.UI.Page
    {
        protected int _idProp;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idProp"] == null)
            {
                Response.Write("<script>alert('Hubo un error');</script>");
                Session["type"] = null;
                Response.Redirect("Login.aspx");
            }
            else
            {
                _idProp= Convert.ToInt32(Session["idProp"].ToString());
            }
            if (!IsPostBack)
            {
                

                Conexion c = new Conexion();
                
                String query = "Select idAnuncio, titulo as 'Título', fechaIni as 'Fecha de inicio', fechaVig as" +
                    "'Fecha de vigencia', descripcion as 'Descripción' from RegAnuncio where idCliente='" + _idProp + "'AND fechaVig> GETDATE()";
                int result = c.fillGrid(query, gvRegAnuncios);
                if(result < 0)
                    Response.Write("<script>alert('Hubo un error al cargar los anuncios');</script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txAnuncio.Text == "")
            {
                Response.Write("<script>alert('Escoge un id de un Anuncio');</script>");
            }
            else
            {
                if (txAnuncio.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Anuncio que deseas eliminar, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String f = String.Format("{0:MM/dd/yy}", DateTime.Today.AddDays(-1));

                            String query = "update RegAnuncio set fechaVig= '" + f + "' where idAnuncio = '" + txAnuncio.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se dio de baja');</script>");

                                String query2 = "Select idAnuncio, titulo as 'Título', fechaIni as 'Fecha de inicio', fechaVig as" +
                                    "'Fecha de vigencia', descripcion as 'Descripción' from RegAnuncio where idCliente='" + _idProp + "'AND fechaVig> GETDATE()";
                                int result = c.fillGrid(query2, gvRegAnuncios);
                                if (result < 0)
                                    Response.Write("<script>alert('Hubo un error al cargar los anuncios');</script>");
                            }

                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('No se pudo dar de baja por el error ');</script>" + err);
                        }
                }
            }
        }
    }
}