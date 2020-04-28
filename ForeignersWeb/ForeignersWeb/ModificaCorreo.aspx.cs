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
            if(Session["idProp"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Cliente c = new Cliente();
                tbCorreoActual.Text = c.getMail(Convert.ToInt32(Session["idProp"]));
            }
      
            
        }

        protected void btnUpMail_Click(object sender, EventArgs e)
        {
            
            if (tbCorreoNuevo.Text == "")
                Response.Write("<script>alert('Escribe el correo nuevo');</script>");
            else
            {
                Conexion c = new Conexion();
                if (c != null)
                    try
                    {
                        string query = String.Format("UPDATE Cliente SET correo='{1}' WHERE correo='{0}'", tbCorreoActual.Text, tbCorreoNuevo.Text);
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
                
            }
            
        }
    }
}