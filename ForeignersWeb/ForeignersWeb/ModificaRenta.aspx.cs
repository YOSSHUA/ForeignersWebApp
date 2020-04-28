using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class ModificaRenta : System.Web.UI.Page
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
                c.fillGrid("SELECT idInm, Inmueble.descripcion as 'Descripcion' , precio as 'Precio' , numHab as 'No. de habitaciones',tel as 'Telefono' , CASE cocina WHEN 1 THEN 'Incluida' WHEN 0 THEN 'No incluida' END AS Cocina,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Inmueble,  catPaises WHERE   catPaises.idPais = Inmueble.idPais and  idPropietario =" + Session["idProp"], gvInm);                
            }
        }

        protected void btnActDesc_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                Response.Write("<script>alert('Escribe la nueva descripción antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del inmueble, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Inmueble set descripcion= '" + txtDesc.Text + "' where idInm = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
                            }
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                }
            }

        }

        protected void btnActFoto_Click(object sender, EventArgs e)
        {
            Renta r = new Renta();
            if (txtIDPic.Text != "")
            {
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
                            int result = r.modificarImg(Convert.ToInt32(txtIDPic.Text), imgarray);
                            if (result > 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                Conexion c = new Conexion();
                                c.fillGrid("SELECT * from catFotosInm WHERE idInm = " + txtID.Text, gvPics);
                            }
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Seleccione la foto de su establecimiento');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Hubo un error al registrar su establecimiento');</script>");
                }
            }
        }

        protected void btnSelectInm_Click(object sender, EventArgs e)
        {
            txtID.Text = HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[1].Text);
            Conexion c = new Conexion();
            c.fillGrid("SELECT * from catFotosInm WHERE idInm = " +txtID.Text, gvPics);
            txtDesc.Text = HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[2].Text);
            txtPrecio.Text = HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[3].Text);
            txtNH.Text = HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[4].Text);
            txtTel.Text= HttpUtility.HtmlDecode(gvInm.SelectedRow.Cells[5].Text);

        }
        public void updateGrid()
        {
            Conexion c = new Conexion();
            try
            {
                c.fillGrid("SELECT idInm, Inmueble.descripcion as 'Descripcion' , precio as 'Precio' , numHab as 'No. de habitaciones',tel as 'Telefono' , CASE cocina WHEN 1 THEN 'Incluida' WHEN 0 THEN 'No incluida' END AS Cocina,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Inmueble,  catPaises WHERE   catPaises.idPais = Inmueble.idPais and  idPropietario =" + Session["idProp"], gvInm);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Hubo un error: " + ex.ToString() + "');</script>");

            }
        }

        protected void gvPics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Renta re = new Renta();
            byte[] resp = re.getFotoById(Convert.ToInt32(gvPics.SelectedRow.Cells[1].Text));
            if (resp != null)
            {
                string pic = Convert.ToBase64String(resp);
                img.ImageUrl = String.Format("data:image/jpg;base64, {0}", pic);
                txtIDPic.Text = gvPics.SelectedRow.Cells[1].Text;
            }
            else
            {
                img.ImageUrl = "";
            }
        }

        protected void btnActP_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "")
            {
                Response.Write("<script>alert('Escribe la nueva descripción antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del inmueble, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Inmueble set precio= '" + txtPrecio.Text + "' where idInm = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
                            }
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                }
            }
        }

        protected void btnActNH_Click(object sender, EventArgs e)
        {
            if (txtNH.Text == "")
            {
                Response.Write("<script>alert('Escribe la nueva descripción antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del inmueble, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Inmueble set numHab = '" + txtNH.Text + "' where idInm = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
                            }
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                }
            }
        }

        protected void btnActTel_Click(object sender, EventArgs e)
        {
            if (txtTel.Text == "")
            {
                Response.Write("<script>alert('Escribe la nueva descripción antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del inmueble, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Inmueble set tel= '" + txtTel.Text + "' where idInm = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
                            }
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: " + err.ToString() + "');</script>");
                        }
                }
            }
        }

        protected void gvPics_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["foto"]);
                (e.Row.FindControl("gvImg") as Image).ImageUrl = imageUrl;
            }
        }
    }
}