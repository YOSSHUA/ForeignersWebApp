using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public int altaRenta(int idProp, string desc, double precio, int numH, bool cocina,string tel, string dir, string del, string cp, string edo, int idPais, string lat, string lng)
        {
            int result = 0;
            String query = "insert into Inmueble (idPropietario, descripcion, precio, numHab, tel, cocina, calleNum, munDel, codP," +
                "estado, idPais, lng, lat) Values ('" + idProp + "' , '" + desc + "','" + precio + "','" + numH + "','" + tel + "','" + cocina + "','"
                + dir + "','" + del + "','" + cp + "','" + edo + "','" + idPais + "','" + lng + "','" + lat + "')";
            Conexion cone = new Conexion();
            result = cone.executeQuery(query);
            return result;
        }
        public int altaImages(int idInm, byte[] image)
        {
            int res=-1;
            Conexion c = new Conexion();            
            res = c.addImageInm(idInm, image);
            return res;
        }
        public int getLastId(int idProp)
        {
            int result;
            Conexion c = new Conexion();
            string query = "SELECT max(idInm) FROM Inmueble WHERE idPropietario ="+idProp;
            SqlDataReader dr = c.getReader(query);
            if (dr.Read())
            {
                result = dr.GetInt32(0);
            }
            else{
                result = -1;
            }
            return result;
        }

        public byte[] getFotoById(int idPic)
        {
            byte[] pic;
            string query = "SELECT foto FROM catFotosInm WHERE idFoto = '" + idPic + "'";
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
        public int modificarImg(int idFoto, byte[] img)
        {
            Conexion c = new Conexion();
            int result = c.updatePicRen(idFoto, img);
            return result;

        }
    }
}