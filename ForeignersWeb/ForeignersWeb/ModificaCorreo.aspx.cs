using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class ModificaCorreo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
            }
      
            
        }

        protected void tbCorreo_TextChanged(object sender, EventArgs e)
        {
            if (tbCorreoActual.Text == "")
            {
                Response.Write("<script>alert('Escribe el correo actual');</script>");
            }
            else
            {
                if (tbCorreoNuevo.Text == "")
                    Response.Write("<script>alert('Escribe el correo nuevo');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            string query = String.Format("UPDATE Cliente SET correo='{0}' WHERE correo='{1}'", tbCorreoActual.Text, tbCorreoNuevo.Text);
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
                    if (tbCorreoActual.Text == "" || tbCorreoNuevo.Text == "")
                    {
                        Response.Write("<script>alert('Escribe el nuevo nombre');</script>");
                    }
                }
            }
        }
    }
}