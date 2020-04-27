using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class Mapa : System.Web.UI.Page
    {
        protected string _centerMap = string.Empty;
        protected string _markers = string.Empty;
        protected int _mapZoomLevel = 5;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["type"] == null || Session["idProp"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            ScriptManager.RegisterStartupScript(this, Page.GetType(), "ClientScript", "initMap()", true);
            _centerMap = "19.345442, -99.200090";
            Locations l = new Locations();
            _markers = l.getLocations();

        }
       
        
    }
}