using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public int insertarEstablecimiento(int idProp,int tipo, String nombre, String des, byte[] pic, string horaA, string horaC, String redSocial, String calleNum, String munDel, String codP, String estado, string lng, string lat,  int pais)
        {
            Conexion c = new Conexion();
            int resp = c.addEstablecimiento(idProp,tipo, nombre, des, pic, horaA, horaC, redSocial, calleNum, munDel, codP, estado, lng, lat, pais);
            return resp;
        }
        public byte[] getFotoById(int idEst)
        {
            byte[] pic;
            string query = "SELECT foto FROM Establecimiento WHERE idEstab = '" + idEst + "'";
            Conexion c = new Conexion();
            DataTable dt = c.llenarDataTable(query);
            try
            {
                if (dt.Rows.Count != 0)
                {
                    pic = (byte[])dt.Rows[0][0];

                }
                else
                    pic = null;

            }
            catch (Exception ex)
            {
                pic = null;
            }
            return pic;
        }
        internal int modificarImg(int idEst, byte[] img)
        {
            int result;
            Conexion c = new Conexion();
            result = c.executeUpdatePicEst(idEst, img);
            return result;
        }
    }
}