using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnInit_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "" || txtUser.Text == "")
            {
                Response.Write("<script>alert('Ingresa todos los datos');</script>");
            }
            else
            {
                Conexion c = new Conexion();
                int result = c.login(txtUser.Text, txtPass.Text); /// 1 si es cliente y 2 si es alumno
                if (result == 0)
                    Response.Write("<script>alert('" + "Datos incorrecto" + "');</script>");
                else
                {
                    Session["type"] = result;
                    if (result == 1)// Cliente
                    {
                        Cliente clt = new Cliente();
                        int idProp_ = clt.getId(txtUser.Text);
                        if (idProp_ == -1)
                        {
                            Response.Write("<script>alert('Hubo un error');</script>");
                            Session["type"] = null;
                            Response.Redirect("Login.aspx");
                        }
                        else
                        {
                            Session["idProp"] = idProp_;
                            Response.Redirect("IndexClient.aspx");
                        }
                    }
                    else // Alumno
                    {
                        Session["mail"] = txtUser.Text;
                        Response.Redirect("IndexStudent.aspx");
                    }
                    
                }

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}