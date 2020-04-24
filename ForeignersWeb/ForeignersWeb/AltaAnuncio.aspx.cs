using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class AltaAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["type"] == null || Session["idProp"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                Conexion c = new Conexion();
                int _idC = Convert.ToInt32(Session["idProp"]);
                c.fillGrid("SELECT [idInm] ,[idPropietario],[descripcion],[precio],[numHab] 'Habitaciones',[tel] 'Telefono', CASE [cocina] WHEN 1 THEN 'Incluida' WHEN 0 THEN 'No incluida' END AS Cocina ,[calleNum] as 'Calle y numero'  ,[munDel] as 'Delegacion' ,[codP] as 'CP' ,[estado] 'Estado', catPaises.nombre as 'Pais' FROM Inmueble, catPaises WHERE idPropietario =" + _idC + "  and catPaises.idPais = Inmueble.idPais", gvInm);
                c.fillGrid("SELECT * FROM Establecimiento WHERE idPropietario = " + Session["idProp"], gvEst);
            }
        }
        protected void btnSelectEst_Click(object sender, EventArgs e)
        {
            try
            {
                txtDesc.Text = gvEst.SelectedRow.Cells[5].Text;
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error"+ex.ToString()+"');</script>");
            }
        }
        protected void btnSelectInm_Click(object sender, EventArgs e)
        {
            try
            {
                txtDesc.Text = gvInm.SelectedRow.Cells[3].Text;
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error" + ex.ToString() + "');</script>");
            }
        }
    }
}