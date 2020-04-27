using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


namespace ForeignersWeb
{
    public partial class ModificaAluno : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["mail"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
                SqlConnection miConexion = c.getConnection();
                if (miConexion != null)
                {
                    try
                    {
                        String query = "select nombre from catUniversidades";
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

        protected void Button1_Click(object sender, EventArgs e) //boton para guardar la foto
        {
            Conexion c = new Conexion();
            SqlConnection miConexion = c.getConnection();
            if (miConexion != null)
            {
                try
                {
                    String correo = Session["mail"].ToString();
                    

                    if (Request.Files.Count > 0)
                    {
                        HttpPostedFile PostedFile = Request.Files[0];

                        if (PostedFile.ContentLength > 0)

                        {
                            int imagefilelenth = PostedFile.ContentLength;
                            byte[] imgarray = new byte[imagefilelenth];
                            HttpPostedFile image = PostedFile;
                            image.InputStream.Read(imgarray, 0, imagefilelenth);
                            string query = "UPDATE Alumno SET foto='" + imgarray + "' WHERE Alumno.correo='" + correo + "'";
                            SqlCommand sql2 = new SqlCommand(query, miConexion);
                            int res = sql2.ExecuteNonQuery();
                            if (res > 0)
                            {
                                lbResult.Text = "se pudo modificar correctamente";

                            }
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Seleccione la foto que desea cambiar');</script>");
                    }
                }
                catch (Exception ex)
                {
                    lbResult.Text = "no se modificó correctamente";
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e) //boton para modificar la uni
        {
            Conexion c = new Conexion();
            SqlConnection miConexion = c.getConnection();
            if (miConexion != null)
            {
                try
                {
                     
                    String correo = Session["mail"].ToString();
                    
                    String query1 = "UPDATE Alumno SET idUni='" + (ddlUni.SelectedIndex+1) + "' where correo ='" + correo + "'";
                    SqlCommand sql2 = new SqlCommand(query1, miConexion);
                    int res = sql2.ExecuteNonQuery();
                    if (res != 0)

                        lbResult.Text = "se pudo modificar correctamente";


                }
                catch (Exception ex)
                {
                    lbResult.Text = "no se modificó correctamente";
                }
            }
        }

       
    }
}


