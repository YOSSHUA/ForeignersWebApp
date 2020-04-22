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
                string conString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
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
                    con.Close();
                }catch(Exception ex)
                {
                    con.Close();
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
                SqlConnection con = getConnection();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds, table);

                ddl.DataSource = ds;
                ddl.DataTextField = show;
                ddl.DataValueField = value;
                ddl.DataBind();
                ddl.SelectedIndex = 0;

                
            }
            catch (Exception ex)
            {

            }
        }
        public SqlDataReader getReader(string query)
        {
            SqlDataReader dr;
            SqlConnection con = getConnection();
            if(con != null)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();
                    
                }catch(Exception ex)
                {
                    dr = null;                   
                }
            }
            else
            {
                dr = null;
            }
            return dr;
        }
        public int executeQuery(string query)
        {
            int res = -1;
            SqlConnection con;
            SqlCommand cmd;
            try
            {
                con = getConnection();
                cmd = new SqlCommand(query, con);
                res = cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                res = -1;   
            }
            return res;
        }
    }
}