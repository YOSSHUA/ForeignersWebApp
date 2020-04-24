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

        public String altaCliente(String correo, String contra, String nombre, String apPat, String apMat, DateTime fN)
        {
            String resp = "No se pudo dar de alta ";
            Conexion c = new Conexion();
            if(c != null)
                try
                {

                    String f = String.Format("{0:MM/dd/yy}", fN);
                    String.Format("{0:MM/dd/yy}", fN);
                    String query = "insert into Cliente (correo, contra, nombre, apPat, apMat, fechaN) Values ('" + correo + "' , '" + contra + "','" + nombre + "', '" + apPat + "', '" + apMat + "','" + f + "')";

                  int res=  c.executeQuery(query);
                    
                    if (res != 0)
                        resp = "si se dio de alta";
                }
                catch ( Exception ex){

            }

           

            return resp;
        }
        public String bajaCliente (String correo)// usando Session["mail"]
        {
            String resp = "no se pudo eliminar ";

            Conexion c = new Conexion();
            if (c != null)
                try
                {
                    string query = "DELETE FROM Cliente WHERE correo = '" + correo+"'";
                   
                    int r = c.executeQuery(query);
                    if (r != 0)
                        resp = "se elimino ";
                }catch(Exception ex)
                {

                }
                    return resp;
        }

    }
}