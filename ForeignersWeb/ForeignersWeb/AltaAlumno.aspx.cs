using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class AltaAlumno : System.Web.UI.Page
    {

        protected SqlConnection conectarBD()
        {
            SqlConnection cnn;
            try
            {
                cnn = new SqlConnection("Data Source=NOEMI-PC;Initial Catalog=BDForeigners;Integrated Security=True");
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
            if (!IsPostBack)
            {
                SqlConnection miConexion = conectarBD();
                if (miConexion != null)
                {
                    try
                    {
                        String query = "select * cat.Universidades.nombre from cat.Universidades";
                        SqlCommand sql = new SqlCommand(query, miConexion);
                        SqlDataReader reader = sql.ExecuteReader();
                        while (reader.Read())
                        {
                            ddlUni.Items.Add(reader.GetString(0));
                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        lbResult.Text = "No se llenó la DropDownList" + ex;
                    }
                }
            }
        }

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            SqlConnection miConexion = conectarBD();
            if (miConexion != null)
            {
                try
                {
                    int idAl;
                    String query1 = "select top(1) idAlumno from alumno order by idAlumno desc";
                    SqlCommand sql1 = new SqlCommand(query1, miConexion);
                    SqlDataReader lec1 = sql1.ExecuteReader();
                    if (lec1.Read())
                    {
                        idAl = lec1.GetInt16(0);
                    }
                    else
                    {
                        idAl = 0;
                    }
                    lec1.Close();
                    String query2 = "insert into alumno values(" + tbCorreo.Text + "','" + tbContra.Text + "','" + tbNombre.Text + "','" + tbApellidoP + "','" + tbApellidoM + "','" + tbFechaNac.Text + "','" + tbSexo + "','" + ddlUni.SelectedIndex + "')";
                    idAl++;
                    Session["idAl"] = idAl;
                    SqlCommand sql2 = new SqlCommand(query2, miConexion);
                    int res = sql2.ExecuteNonQuery();
                    if (res != 0)
                    {
                        lbResult.Text = "Alta exitosa";
                    }
                }
                catch (Exception ex)
                {
                    lbResult.Text = "No se dio de alta" + ex;
                }
            }
        }

        protected void ddlUni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}