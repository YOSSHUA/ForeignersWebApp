using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public class Conexion
    {
        public Conexion()
        {

        }
        public SqlConnection getConnection()
        {
            SqlConnection resp;
            try {
                string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
                resp = new SqlConnection(conString);
                resp.Open();
            } catch (Exception ex)
            {
                resp = null;
            }
            return resp;
        }
        public int login(string user, string password)
        {
            int resp = 0;
            SqlConnection con = getConnection();
            if(con!= null)
            {
                try
                {
                    string query = "SELECT contra FROM Cliente WHERE correo = '"+ user+"'";
                    SqlCommand cmd0 = new SqlCommand(query, con);
                    SqlDataReader dr0 = cmd0.ExecuteReader();
                    if (dr0.Read())
                    {
                        if (dr0.GetString(0).Equals(password))
                            resp = 1;
                        dr0.Close();
                    }
                    else{
                        dr0.Close();
                        query = "SELECT contra FROM Alumno WHERE correo = '" + user + "'";
                        SqlCommand cmd1 = new SqlCommand(query, con);
                        SqlDataReader dr1 = cmd1.ExecuteReader();
                        if (dr1.Read())
                        {
                            if (dr1.GetString(0).Equals(password))
                                resp = 2;
                            dr1.Close();
                        }
                    }
                }catch(Exception ex)
                {
                    
                }
            }

            return resp;
        }
        public String bajaCliente(String correo)
        {
            String resp = "No se pudo dar de baja";
            SqlConnection con = getConnection();
            if (con != null)
            {
                try
                {
                    string query = "delete Cliente where correo= '" + correo + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                        resp = "Se dio de baja correctamente";
                }
                catch (Exception ex)
                {

                }
            }

            return resp;
        }
        public String bajaAnuncio(int idAnuncio)
        {
            String resp = " No se pudo eliminar";
            SqlConnection con = getConnection();
            if (con != null)
            {
                try
                {
                    string query = "delete RegAnuncio where idAnuncio= '" + idAnuncio + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int res = cmd.ExecuteNonQuery();
                    if (res != 0)
                        resp = "Se elimino correctamente";
                }
                catch (Exception ex)
                {

                }
            }

            return resp;

        }
        public String altaCliente(String correo, String contra, String nombre, String apPat, String apMat, DateTime fN)
        {
            String resp = "No se dio de alta";
            SqlConnection con = getConnection();
            if (con != null)
            {
                try
                {
                    String f = String.Format("{0:MM/dd/yy}", fN);
                    String.Format("{0:MM/dd/yy}", fN);
                    String query = "insert into Cliente (correo, contra, nombre, apPat, apMat, fechaN) Values ('" + correo + "' , '" + contra + "','" + nombre + "', '" + apPat + "', '" + apMat + "','" + f + "')";
                    SqlCommand cmd1 = new SqlCommand(query, con);
                    int res =cmd1.ExecuteNonQuery();
                    if (res != 0)
                        resp = "Se dio de alta";



                } catch( Exception ex)
                {

                }
                }
            return resp;
        }
        public DataTable llenarDataTable(string query)
        {
            DataTable ans = new DataTable();
            SqlConnection con;
            try
            {
                con = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(ans);
                con.Close();

            }
            catch (Exception ex)
            {
                ans = null;
            }
            return ans;
        }
        public void fillDDL(string query, DropDownList ddl, string table, string show, string value)
        {
            try
            {
                DataRow drow;
                SqlConnection con = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, table);

                
            }
            catch (Exception ex)
            {

            }
        }
    }
}