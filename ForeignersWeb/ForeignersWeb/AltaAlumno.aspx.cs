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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
                SqlConnection miConexion = c.getConnection();
                if (miConexion != null)
                {
                    try
                    {
                        String query = "select catUniversidades.nombre from catUniversidades";
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
            if(Convert.ToDateTime(tbFechaNac.Text) >= DateTime.Today)
            {
                Response.Write("<script>alert('Ingrese una fecha de nacimiento válida');</script>");
                return;
            }
            
            Conexion c = new Conexion();
            SqlConnection miConexion = c.getConnection();
            if (miConexion != null)
            {
                try
                {
                    
                    String query2 = "insert into alumno(correo, contra, nombre, apPat, apMat, fechaN, sexo, idUni) values('" + tbCorreo.Text + "','" + tbContra.Text + "','" + tbNombre.Text + "','" + tbApellidoP.Text + "','" + tbApellidoM.Text + "','" + tbFechaNac.Text + "','" + ddlSexo.SelectedValue + "','" + (ddlUni.SelectedIndex+1) + "')";
                    
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

       
    }
}