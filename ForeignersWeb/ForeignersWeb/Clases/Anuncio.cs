
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForeignersWeb.Clases
{
    public class Anuncio
    {
        public Anuncio()
        {

        }        
        public int altaAnuncio(int tipo, string titulo, string fechaVig, string desc, int idTipo, int idCliente)
        {
            /// Tipo : 1 si es renta, 2 si es establecimiento, 0 en cualquier otro caso
            /// idTipo: si Tipo es 1 tiene el id del inmueble en renta, si Tipo es 2 tiene el id del estabelcimiento, 0 en c. o. c.
            int resp = -1;
            Conexion c = new Conexion();
            string query;
            if (tipo == 1 )
            {                
                query = String.Format("INSERT INTO RegAnuncio(titulo, fechaIni, fechaVig, descripcion, idInm, idCliente) VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}')", titulo, DateTime.Today.ToString("dd/MM/yyyy"), fechaVig, desc, idTipo, idCliente);
            }else if(tipo == 2)
            {
                query = String.Format("INSERT INTO RegAnuncio(titulo, fechaIni, fechaVig, descripcion, idEst, idCliente) VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}')", titulo, DateTime.Today.ToString("dd/MM/yyyy"), fechaVig, desc, idTipo, idCliente);
            }
            else
            {
                query = String.Format("INSERT INTO RegAnuncio(titulo, fechaIni, fechaVig, descripcion, idCliente) VALUES('{0}', '{1}','{2}', '{3}','{4}', '{5}')", titulo, DateTime.Today.ToString("dd/MM/yyyy"), fechaVig, desc, idCliente);
            }
            resp = c.executeQuery(query);
            return resp;
        }
   
    }
}