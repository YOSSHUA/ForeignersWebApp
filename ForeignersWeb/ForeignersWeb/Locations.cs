using GoogleMapsApi.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ForeignersWeb
{
    public class Locations
    {        
        public int id { get; set; }
        public int tipo { get; set; }
        public string dir { get; set; }
        public string nombre { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string desc { get; set; }
        public string tel { get; set; }


        public string getLocations()
        {
            string resp = "";
            try
            {
                Establecimiento est = new Establecimiento();
                Renta ren = new Renta();
                resp = "[";
                DataTable r, e;
                e = est.getLocations();
                r = ren.getLocations();
                for (int i = 0; i < r.Rows.Count; i++) ///Renta
                {
                    Locations aux = new Locations();

                    int id = Convert.ToInt32(r.Rows[i][0]);
                    aux.id = id;
                    aux.desc = r.Rows[i][1].ToString();
                    aux.tel = r.Rows[i][2].ToString();
                    aux.dir = r.Rows[i][3].ToString();

                    
                    string lat = r.Rows[i][4].ToString().Replace(",",".");
                    string lng = r.Rows[i][5].ToString().Replace(",", ".");

                    resp += "{";
                    resp += string.Format("'title': '{0}',", "Lugar para rentar");
                    resp += string.Format("'tel': '{0}',", aux.tel);
                    resp += string.Format("'description': '{0}',", aux.desc);
                    resp += string.Format("'lat': '{0}',", lat);
                    resp += string.Format("'lng': '{0}'", lng);
                    resp += "},";
                }

                for (int i = 0; i < e.Rows.Count; i++) ///Establecimiento
                {
                    Locations aux = new Locations();

                    int id = Convert.ToInt32(e.Rows[i][0]);
                    aux.id = id;
                    aux.tipo = 1;
                    aux.nombre = e.Rows[i][1].ToString();
                    aux.desc = e.Rows[i][2].ToString();
                    aux.dir = e.Rows[i][3].ToString();
                    string lat = e.Rows[i][4].ToString().Replace(",", ".");
                    string lng = e.Rows[i][5].ToString().Replace(",", ".");

                    resp += "{";
                    resp += string.Format("'title': '{0}',", "Establecimiento" + aux.nombre);
                    resp += string.Format("'description': '{0}',", aux.desc);
                    resp += string.Format("'tel': '{0}',", "");
                    resp += string.Format("'lat': '{0}',", lat);
                    resp += string.Format("'lng': '{0}'", lng);
                    resp += "},";

                }
                resp += "];";

            }
            catch (Exception ex)
            {
                resp = null;
            }
            
            return resp;
        }
    }
}