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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String correo = Session["mail"].ToString();
                Cliente cli = new Cliente();
                int idcli = cli.getId(correo);

                Conexion c = new Conexion();
                SqlConnection miConexion = c.getConnection();
                if (miConexion != null)
                {
                    try
                    {
                        String query = "Select idAnuncio, titulo as 'Título', fechaIni as 'Fecha de inicio', fechaVig as" +
                            "'Fecha de vigencia', descripcion as 'Descripción' from RegAnuncio where idCliente='" + idcli + "'AND fechaVig> GETDATE()";
                        SqlDataReader dr = c.getReader(query);
                        SqlCommand cmd = new SqlCommand(query, miConexion);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        gvRegAnuncios.DataSource = ds;
                        gvRegAnuncios.DataBind();



                    }
                    catch (Exception ex)
                    {
                        
                        
                    }
                }
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
                Conexion c = new Conexion();
                if (c != null)
                    try
                    {
                        String f = String.Format("{0:MM/dd/yy}", DateTime.Today.AddDays(-1));

                        String query = "update RegAnuncio set fechaVig= '" + f + "' where idAnuncio = '" + txAnuncio.Text + "'";
                        int res = c.executeQuery(query);

                        if (res != 0)
                            Response.Write("<script>alert('Se dio de baja');</script>");






                    }
                    catch (Exception err)
                    {
                        Response.Write("<script>alert('No se pudo dar de baja por el error ');</script>" + err);
                    }
            }
        }
    }
}