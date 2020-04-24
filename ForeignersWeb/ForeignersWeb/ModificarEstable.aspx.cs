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
            if (!IsPostBack)
            {

                Conexion c = new Conexion();
                int _idC = Convert.ToInt32(Session["idProp"]);
                c.fillGrid("SELECT idEstab as 'ID', idPropietario as 'ID Propietario'  , catTipoEst.descripcion as 'Tipo' , Establecimiento.nombre as 'Nombre' , Establecimiento.descripcion as 'Descripcion' ,[horaA] as 'Hora de apertura'  ,[horaC] as 'Hora de cierre'  ,[redSocial] as 'Red social' ,[calleNum] as 'Calle y No.' ,[munDel] as 'Delegacion'  ,[codP] as 'CP' ,[estado] as 'Estado' , catPaises.nombre as 'Pais' FROM Establecimiento, catTipoEst, catPaises WHERE Establecimiento.tipo = catTipoEst.idTipo and  catPaises.idPais = Establecimiento.idPais and  idPropietario =" + Session["idProp"], GridView1);
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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set nombre= '" + txtNom.Text + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {

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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {

                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set descripcion= '" + txtDesc.Text + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {

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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set horaA= '" + txtHA.Text + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {

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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del Establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set horaC= '" + txtHC.Text + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {

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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set redSocial= '" + txtRedS.Text + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {

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
                if (TextBoxID.Text == "")
                    Response.Write("<script>alert('No has escogido el id del establecimiento, asegúrate de llenar esa casilla');</script>");
                else
                {

                    int tipo = Convert.ToInt32(ddlTipoEst.SelectedValue);
                    Conexion c = new Conexion();
                    if (c != null)
                        try
                        {
                            String query = "update Establecimiento set tipo= '" + tipo + "' where idEstab = '" + TextBoxID.Text + "'";
                            int res = c.executeQuery(query);

                            if (res != 0)
                                Response.Write("<script>alert('Se Modificó correctamente');</script>");
                        }
                        catch (Exception err)
                        {
                            Response.Write("<script>alert('Se Modificó correctamente');</script>" + err);

                        }
                }
            }
        }

        protected void btnActFoto_Click(object sender, EventArgs e)
        {

        }
    }
}