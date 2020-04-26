using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class ModificarEstable : System.Web.UI.Page
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
                c.fillGrid("SELECT idEstab as 'ID'  , catTipoEst.descripcion as 'Tipo' , Establecimiento.nombre as 'Nombre' , Establecimiento.descripcion as 'Descripcion' ,[horaA] as 'Hora de apertura'  ,[horaC] as 'Hora de cierre'  ,[redSocial] as 'Red social' ,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Establecimiento, catTipoEst, catPaises WHERE Establecimiento.tipo = catTipoEst.idTipo and  catPaises.idPais = Establecimiento.idPais and  idPropietario =" + Session["idProp"], gvEst);
                c.fillDDL("SELECT idTipo, descripcion FROM catTipoEst", ddlTipoEst, "catTipoEst", "descripcion", "idTipo");
            }
        }

        protected void btActNombre_Click(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                Response.Write("<script>alert('Escribe el nuevo nombre');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set nombre= '" + txtNom.Text + "' where idEstab = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0) {
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

        protected void btnActDesc_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "")
            {
                Response.Write("<script>alert('Escribe la nueva descripción antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set descripcion= '" + txtDesc.Text + "' where idEstab = '" + txtID.Text + "'";
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

        protected void btnActHA_Click(object sender, EventArgs e)
        {
            if (txtHA.Text == "")
            {
                Response.Write("<script>alert('Escribe el nuevo horario de apertura');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set horaA= '" + txtHA.Text + "' where idEstab = '" + txtID.Text + "'";
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

        protected void btnActHC_Click(object sender, EventArgs e)
        {
            if (txtHC.Text == "")
            {
                Response.Write("<script>alert('Escribe el nuevo horario de apertura');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set horaC= '" + txtHC.Text + "' where idEstab = '" + txtID.Text + "'";
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

        protected void btnActFb_Click(object sender, EventArgs e)
        {
            if (txtRedS.Text == "")
            {
                Response.Write("<script>alert('Escribe el nuevo Facebook');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set redSocial= '" + txtRedS.Text + "' where idEstab = '" + txtID.Text + "'";
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

        protected void btnAct_Click(object sender, EventArgs e)
        {
            if (ddlTipoEst.SelectedValue == null)
            {
                Response.Write("<script>alert('Escoge un nuevo tipo antes de actualizar');</script>");
            }
            else
            {
                if (txtID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {

                    int tipo = Convert.ToInt32(ddlTipoEst.SelectedValue);
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set tipo= '" + tipo + "' where idEstab = '" + txtID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
                            }
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Error: "+err.ToString()+"');</script>");

                        }
                }
            }
        }

        protected void btnActFoto_Click(object sender, EventArgs e)
        {
            Establecimiento est = new Establecimiento();
            if (txtID.Text != "") {
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
                            int result = est.modificarImg(Convert.ToInt32(txtID.Text), imgarray);
                            if(result > 0)
                            {
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                                updateGrid();
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
            txtID.Text = HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[1].Text);
            Establecimiento est = new Establecimiento();
            byte[] resp = est.getFotoById(Convert.ToInt32(txtID.Text));
            if (resp != null) {
                string pic = Convert.ToBase64String(resp);
                img.ImageUrl = String.Format("data:image/jpg;base64, {0}", pic);

            }
            else
            {
                img.ImageUrl = "";
            }
            ddlTipoEst.SelectedValue = ddlTipoEst.Items.FindByText(HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[2].Text)).Value;
            txtNom.Text= HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[3].Text);
            txtDesc.Text = HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[4].Text);
            txtHA.Text=HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[5].Text);
            txtHC.Text = HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[6].Text);
            txtRedS.Text = HttpUtility.HtmlDecode(gvEst.SelectedRow.Cells[7].Text);
        }
        public void updateGrid()
        {
            Conexion c = new Conexion();
            try
            {
                c.fillGrid("SELECT idEstab as 'ID'  , catTipoEst.descripcion as 'Tipo' , Establecimiento.nombre as 'Nombre' , Establecimiento.descripcion as 'Descripcion' ,[horaA] as 'Hora de apertura'  ,[horaC] as 'Hora de cierre'  ,[redSocial] as 'Red social' ,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Establecimiento, catTipoEst, catPaises WHERE Establecimiento.tipo = catTipoEst.idTipo and  catPaises.idPais = Establecimiento.idPais and  idPropietario =" + Session["idProp"], gvEst);
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('Hubo un error: " + ex.ToString() + "');</script>");
                
            }
        }
    }
}