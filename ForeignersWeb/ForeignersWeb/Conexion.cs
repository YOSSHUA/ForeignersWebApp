﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

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
    }
}