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
                Session["_typeA"]= 3;
                
            }
            Conexion c = new Conexion();
            int _idC = Convert.ToInt32(Session["idProp"]);
            c.fillGrid("SELECT idInm ,idPropietario,descripcion,precio,numHab 'Habitaciones',tel 'Telefono', CASE cocina WHEN 1 THEN 'Incluida' WHEN 0 THEN 'No incluida' END AS Cocina ,calleNum as 'Calle y numero'  ,munDel as 'Delegacion' ,codP as 'CP' ,estado 'Estado', catPaises.nombre as 'Pais' FROM Inmueble, catPaises WHERE idPropietario =" + _idC + "  and catPaises.idPais = Inmueble.idPais", gvInm);
            c.fillGrid("SELECT idEstab as 'ID', idPropietario as 'ID Propietario'  , catTipoEst.descripcion as 'Tipo' , Establecimiento.nombre as 'Nombre' , Establecimiento.descripcion as 'Descripcion' ,[horaA] as 'Hora de apertura'  ,[horaC] as 'Hora de cierre'  ,[redSocial] as 'Red social' ,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Establecimiento, catTipoEst, catPaises WHERE Establecimiento.tipo = catTipoEst.idTipo and  catPaises.idPais = Establecimiento.idPais and  idPropietario =" + Session["idProp"], gvEst);
        }
        protected void btnSelectEst_Click(object sender, EventArgs e)
        {
            Session["selR"] = Convert.ToInt32(gvEst.SelectedIndex);
            try
            {
                txtDesc.Text = "Nombre: " + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[4].Text) + "\nTipo:" + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[3].Text) + "\nDescripcion: " + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[5].Text) + "\nHora de apertura " + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[6].Text) + "\nHora de cierre: "+ HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[7].Text) + "Pagina web: " + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[8].Text) + "\nDirección: " + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[9].Text) + (HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[9].Text) == "" ? "" : HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[10].Text) + (HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[10].Text) == "" ? "" : HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[11].Text) + (HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[11].Text) == "" ? "" : HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[12].Text) + "," + HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[13].Text);
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error"+ex.ToString()+"');</script>");
            }
        }
        protected void btnSelectInm_Click(object sender, EventArgs e)
        {
            Session["selR"] = Convert.ToInt32(gvInm.SelectedIndex);
            try
            {
                txtDesc.Text = "Descripcion: "+ HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[3].Text) + "\nPrecio: $" + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[4].Text) +  "\nNo. de habitaciones: " + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[5].Text) + "\nContacto: "+ HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[6].Text) + "\nCocina " + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[7].Text) + "\nDirección: "+ HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[8].Text) + (HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[8].Text) == "" ? "" : HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[9].Text)+ (HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[9].Text)==""? "": HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[10].Text)+ (HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[10].Text) == "" ? "" : HttpUtility.HtmlDecode(" ")) + HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[11].Text)+","+ HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[12].Text);
            }catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error" + ex.ToString() + "');</script>");
            }
        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                int _typeA = Convert.ToInt32(Session["_typeA"]);
                int selectedR = Convert.ToInt32(Session["selR"]);
                if (txtDesc.Text == "" || txtTitle.Text == "" || dtpF.SelectedDate.ToString() == "")
                {
                    Response.Write("<script>alert('Llena todos los campos');</script>");
                    return;
                }
                int resp;
                Clases.Anuncio a = new Clases.Anuncio();
                if (_typeA == 1)
                { /// Renta                
                    resp = a.altaAnuncio(_typeA, txtTitle.Text, dtpF.SelectedDate.ToString("dd/MM/yyyy"), txtDesc.Text, Convert.ToInt32(HttpUtility.HtmlDecode(gvInm.Rows[selectedR].Cells[1].Text)), Convert.ToInt32(Session["idProp"]));
                }
                else if (_typeA == 2) // Establecimiento
                {
                    resp = a.altaAnuncio(_typeA, txtTitle.Text, dtpF.SelectedDate.ToString("dd/MM/yyyy"), txtDesc.Text, Convert.ToInt32(HttpUtility.HtmlDecode(gvInm.Rows[selectedR].Cells[1].Text)), Convert.ToInt32(Session["idProp"]));
                }
                else//Otro
                {
                    resp = a.altaAnuncio(_typeA, txtTitle.Text, dtpF.SelectedDate.ToString("dd/MM/yyyy"), txtDesc.Text, 0, Convert.ToInt32(Session["idProp"]));
                }
                if (resp > 0)
                {
                    Response.Write("<script>alert('Se registro correctamente');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Hubo un error al registrar su anuncio');</script>");
                }
                Session["_typeA"] = null;
                Session["selR"] = null;
                Response.Redirect("IndexClient.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hubo un error al registrar su anuncio');</script>");
            }
        }

        protected void rbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["_typeA"] = Convert.ToInt32(rbList.SelectedValue);            
            if (Convert.ToInt32(rbList.SelectedValue)== 1) //Renta
            {                
                rowInm.Enabled = true;
                rowEst.Enabled = false;
            }else if (Convert.ToInt32(rbList.SelectedValue) == 2)// Establecimiento
            {
                rowInm.Enabled = false;
                rowEst.Enabled = true;
            }
            else{
                rowInm.Enabled = false;
                rowEst.Enabled = false;
            }
        }

        protected void dtpF_DayRender(object sender, DayRenderEventArgs e)
        {
            if(e.Day.Date <= DateTime.Today)
            {
                e.Day.IsSelectable = false;
            }
        }
    }
}