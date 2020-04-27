using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class BajaAlumno : System.Web.UI.Page
    {

          
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            SqlConnection miConexion = c.getConnection();
            
            
            if (miConexion != null)
            {
                try
                {
                    String query1 = "DELETE from Alumno where correo='"+Session["mail"].ToString() + "'"+"AND contra='"+tbContra2.Text+"'";
                    SqlCommand sql1 = new SqlCommand(query1, miConexion);
                    int res = sql1.ExecuteNonQuery();
                    if (res != 0)
                        lbResult.Text = "Se dio de baja correctamente";
                }
                catch (Exception ex)
                {
                    lbResult.Text = "no se pudo dar de baja" + ex.StackTrace.ToString(); //stacktrace da la guia del error
                }
            }
        }
    }
}