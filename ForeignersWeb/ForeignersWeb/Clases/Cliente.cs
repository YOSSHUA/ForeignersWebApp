using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ForeignersWeb
{
    public class Cliente
    {
        public Cliente()
        {

        }
        public int getId(string mail)
        {
            int resp = -1;
            Conexion c = new Conexion();
            string query = "SELECT idCliente FROM Cliente WHERE correo = '" + mail + "'";
            SqlDataReader dr = c.getReader(query);
            if (dr != null)
            {
                if (dr.Read())
                {
                    resp = dr.GetInt32(0);
                }
            }
            return resp;
              
        }
    }
}