using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class IndexStudent : System.Web.UI.Page
    {
        protected string _centerMap = string.Empty;
        protected string _markers = string.Empty;
        protected int _mapZoomLevel = 5;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["mail"] == null)
            {
                Response.Redirect("Login.aspx");
            }            
            ScriptManager.RegisterStartupScript(this, Page.GetType(), "ClientScript", "initMap()", true);
            _centerMap = "19.345442, -99.200090";
            Locations l = new Locations();
            _markers = l.getLocations();
            string queryAn = "SELECT [titulo] ,[fechaIni] as 'Fecha de inicio' ,[fechaVig] as 'Fecha de vigencia'  ,[descripcion] FROM RegAnuncio";
            Conexion c = new Conexion();
            c.fillGrid(queryAn, gvAnuncios);
        }

        

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaAlumno.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificaAlumno.aspx");
        }
    }
}