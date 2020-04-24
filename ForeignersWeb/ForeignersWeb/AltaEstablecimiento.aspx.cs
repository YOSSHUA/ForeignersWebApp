using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace ForeignersWeb
{
    public partial class AltaEstablecimiento : System.Web.UI.Page
    {
        int idProp_;
        protected string _lat0 = string.Empty;
        protected string _lng0 = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idProp"] == null)
            {
                Response.Write("<script>alert('Hubo un error');</script>");
                Session["type"] = null;
                Response.Redirect("Login.aspx");
            }
            else
            {
                idProp_ = Convert.ToInt32(Session["idProp"].ToString());
            }
            if (!IsPostBack)
            {
                
                Conexion con = new Conexion();
                con.fillDDL("SELECT idPais, nombre FROM catPaises", ddlPais, "catPaises", "nombre", "idPais");
                con.fillDDL("SELECT idTipo, descripcion FROM catTipoEst", ddlTipoEst, "catTipoEst", "descripcion", "idTipo");
            }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (Request.Files.Count == 0 || txtCalle.Text=="" || txtColDel.Text=="" || txtCP.Text=="" || txtDesc.Text=="" || txtEdo.Text=="" || txtNom.Text=="" || txtRedS.Text=="")
            {
                Response.Write("<script>alert('Llenar todos los campos');</script>");
                return;
            }
            Establecimiento est = new Establecimiento();
            try
            {
                if (Request.Files.Count > 0)
                {
                    HttpPostedFile PostedFile = Request.Files[0];

                    if (PostedFile.ContentLength > 0)

                    {
                        int imagefilelenth = PostedFile.ContentLength;
                        byte[] imgarray = new byte[imagefilelenth];
                        HttpPostedFile image = PostedFile;
                        image.InputStream.Read(imgarray, 0, imagefilelenth);
                        int res = est.insertarEstablecimiento(idProp_, Convert.ToInt32(ddlTipoEst.SelectedValue), txtNom.Text, txtDesc.Text, imgarray, tpHA.SelectedDate, dpHC.SelectedDate, txtRedS.Text, txtCalle.Text, txtColDel.Text, txtCP.Text, txtEdo.Text, lblLat.Text, lblLng.Text, Convert.ToInt32(ddlPais.SelectedValue));
                        if (res > 0)
                        {
                            Response.Write("<script>alert('Se registro correctamente su establecimiento');</script>");
                            Response.Redirect("IndexClient.aspx");

                        }
                    }
                }
                else
                {
                    Response.Write("<script>alert('Seleccione la foto de su establecimiento');</script>");
                }
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error al registrar su establecimiento');</script>");                    
            }
        }

        protected void btnBuscarDir_Click(object sender, EventArgs e)
        {
            try
            {
                string address = txtCalle.Text + "," + txtColDel.Text + "," + txtEdo.Text + "," + txtCP.Text + "," + ddlPais.SelectedItem.Text;
                string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?key={1}&address={0}&sensor=false", Uri.EscapeDataString(address), "AIzaSyASt_r2bn3WZMmgBVVQLluzFdstRqaMZzc");

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement status = xdoc.Element("GeocodeResponse").Element("status");
                if (status.Value == "OK")
                {
                    XElement result = xdoc.Element("GeocodeResponse").Element("result");
                    XElement locationElement = result.Element("geometry").Element("location");
                    XElement lat = locationElement.Element("lat");
                    XElement lng = locationElement.Element("lng");
                    _lat0 = lat.Value.ToString();
                    lblLat.Text = lat.Value.ToString();
                    _lng0 = lng.Value.ToString();
                    lblLng.Text = lng.Value.ToString();
                    ScriptManager.RegisterStartupScript(this, Page.GetType(), "ClientScript", "initMap()", true);
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hubo un error al buscar la direccion, intente de nuevo');</script>");
            }
        }
    }
}