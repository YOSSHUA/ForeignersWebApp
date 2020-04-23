using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;

namespace ForeignersWeb
{
    public partial class AltaRenta : System.Web.UI.Page
    {
        int idProp_;
        protected string _lat = string.Empty;
        protected string _lng = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                Conexion con = new Conexion();
                con.fillDDL("SELECT idPais, nombre FROM catPaises", ddlPais, "catPaises", "nombre", "idPais");
            }
            
            Cliente c = new Cliente();
            idProp_ = c.getId(Session["mail"].ToString());
            if (idProp_ == -1)
            {
                Response.Write("<script>alert('Hubo un error');</script>");
                Session["type"] = null;
                Session["mail"] = null;
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            Renta r = new Renta();
            bool cocina = ddlCocina.SelectedValue == "1" ? true : false;
            int res = r.altaRenta(idProp_, txtDesc.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtNumH.Text), cocina, txtTel.Text, txtCalle.Text, txtColDel.Text, txtCP.Text, txtEdo.Text, Convert.ToInt32(ddlPais.SelectedValue), lblLat.Text,lblLng.Text);
            if (res > 0)
            {
                int idInm = r.getLastId(idProp_);
                if(idInm > 0)
                {
                    Session["idInm"] = idInm;
                    Response.Redirect("AltaRenta2.aspx");
                }
            }

            
            

                
            
        }
        
        protected void btnBuscarDir_Click(object sender, EventArgs e)
        {
            string address = txtCalle.Text + "," + txtColDel.Text + "," + txtEdo.Text + "," + txtCP.Text + "," + ddlPais.SelectedItem.Text;
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), "AIzaSyASt_r2bn3WZMmgBVVQLluzFdstRqaMZzc");

            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());

            XElement status = xdoc.Element("GeocodeResponse").Element("status");
            if(status.Value == "OK")
            {
                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");
                _lat = lat.Value.ToString();
                lblLat.Text = lat.Value.ToString();
                _lng = lng.Value.ToString();
                lblLng.Text = lng.Value.ToString();
                ScriptManager.RegisterStartupScript(this, Page.GetType(), "ClientScript", "initMap()", true);
            }
        }

        
        

    }
}