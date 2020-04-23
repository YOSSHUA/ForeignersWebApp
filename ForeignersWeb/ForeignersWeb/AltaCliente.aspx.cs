using System;
using System.Collections.Generic;
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
		protected void btAgregar_Click(object sender, EventArgs e)
		{
			Cliente c = new Cliente();
			String resp = c.altaCliente(TextBox1Nombre.Text, TextBoxContra.Text, TextBox1Nombre.Text, txApePat.Text, TextBoxApeMat.Text, FechaNac.SelectedDate);
			lblRespuesta.Text = resp;

		}
	}
}