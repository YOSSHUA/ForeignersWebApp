using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class AltaCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {

            Conexion c = new Conexion();
            
            lblResultado.Text = c.altaCliente(txCorreo.Text, txContra.Text, txNombre.Text, txApPat.Text, txApMAt.Text, FechaNac.SelectedDate);
        }
    }
}