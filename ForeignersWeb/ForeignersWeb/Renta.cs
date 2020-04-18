using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ForeignersWeb
{
    public class Renta
    {
        public Renta()
        {

        }
        public DataTable getLocations()
        {
            string query = "SELECT idInm,descripcion, tel, calleNum, lat, lng FROM Inmueble";
            Conexion c = new Conexion();
            DataTable resp = c.llenarDataTable(query);
            return resp;
        }
    }
}