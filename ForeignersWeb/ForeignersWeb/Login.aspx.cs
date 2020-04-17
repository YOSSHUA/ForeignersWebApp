using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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
                int result = c.login(txtUser.Text, txtPass.Text);
                if (result == 0)
                    Response.Write("<script>alert('" + "Datos incorrecto" + "');</script>");
                else
                {
                    Session["type"] = result;
                    Session["mail"] = txtUser.Text;
                    Response.Redirect("Index.aspx");
                }

            }
        }
    }
}