using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["type"] == null || Session["idProp"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                int idP = Convert.ToInt32(Session["idProp"]);
                Conexion c = new Conexion();
                string queryEst = "SELECT  idEstab, catTipoEst.descripcion as 'Tipo' , Establecimiento.nombre as 'Nombre' , Establecimiento.descripcion as 'Descripcion' ,[horaA] as 'Hora de apertura'  ,[horaC] as 'Hora de cierre'  ,[redSocial] as 'Red social' ,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Establecimiento, catTipoEst, catPaises WHERE Establecimiento.tipo = catTipoEst.idTipo and  catPaises.idPais = Establecimiento.idPais and  idPropietario =" + idP;
                string queryInm = "SELECT idInm,[descripcion], precio, numHab, cocina, tel ,[calleNum] ,[munDel] ,[codP] ,[estado] , catPaises.nombre  FROM Inmueble, catPaises WHERE Inmueble.idPais= catPaises.idPais and idPropietario = " + idP;
                string queryAn = "SELECT [titulo] ,[fechaIni] as 'Fecha de inicio' ,[fechaVig] as 'Fecha de vigencia'  ,[descripcion]  ,[idEst] 'ID del inmueble' ,[idInm] 'ID del establecimiento' FROM RegAnuncio WHERE idCliente = " + idP;
                c.fillGrid(queryEst, gvEst);
                c.fillGrid(queryInm, gvInm);
                c.fillGrid(queryAn, gvAnuncios);
            }
        }

        protected void lkBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mapa.aspx");
        }

        protected void lkBtnAltaRenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaRenta.aspx");
        }

        protected void lkBtnAltaCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaCliente.aspx");
        }

        protected void lkBajaAnuncio_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaAnuncio.aspx");
        }

        protected void lkBajaCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("BajaCliente.aspx");
        }

        protected void lkBtnAltaEst_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaEstablecimiento.aspx");
        }

        protected void lkBtnAltaAnuncio_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaAnuncio.aspx");
        }

        protected void lkBtnModiEstab_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarEstable.aspx");

        }

        protected void lkBtnModiAnun_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificaAnuncio.aspx");
        }

        protected void lkBtnModMail_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificaCorreo.aspx");
        }

        protected void lkBtnModRenta_Click(object sender, EventArgs e)
        {
            Response.Redirect("ModificarRenta.aspx");
        }
    }
}