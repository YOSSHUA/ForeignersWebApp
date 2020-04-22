using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public class Establecimiento
    {
        public Establecimiento()
        {

        }
        public void FillDDLTypes(DropDownList ddl)
        {
            Conexion c = new Conexion();
            string query = "SELECT * FROM catTipoEst";
            string tabla = "catTipoEst";
            string show = "descripcion";
            string value = "idTipo";
            c.fillDDL(query, ddl, tabla, show, value);
        }
        public DataTable getLocations()
        {
            string query = "SELECT idEstab, nombre, descripcion,calleNum, lat, lng FROM Establecimiento";
            Conexion c = new Conexion();
            DataTable resp = c.llenarDataTable(query);
            return resp;
        }
    }
}