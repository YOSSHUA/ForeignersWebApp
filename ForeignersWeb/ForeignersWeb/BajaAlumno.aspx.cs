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

        protected SqlConnection conectarBD()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=LAPTOP-U5UTRRH6;Initial Catalog=Foreigners;Integrated Security=True");
                cnn.Open();

            }
            catch (Exception ex)
            {
                cnn = null;

            }
            return cnn;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                try
                {
                    String query1 = "DELETE from alumno where correo='" + tbCorreo2 + "'"+"AND contra='"+tbContra2+"'";
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