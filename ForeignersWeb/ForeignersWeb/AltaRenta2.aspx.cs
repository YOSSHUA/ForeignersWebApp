using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ForeignersWeb
{
    public partial class AltaRenta2 : System.Web.UI.Page
    {
        protected int idProp_;
        protected int idInm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idProp"] == null || Session["idInm"]==null)
            {
                Response.Write("<script>alert('Hubo un error');</script>");
                Session["type"] = null;
                Response.Redirect("Login.aspx");
            }
            else
            {
                idProp_ = Convert.ToInt32(Session["idProp"].ToString());
                idInm = Convert.ToInt32(Session["idInm"]);
            }
            
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            Renta r = new Renta();

            for (int i = 0; i < Request.Files.Count; i++)

            {

                HttpPostedFile PostedFile = Request.Files[i];

                if (PostedFile.ContentLength > 0)

                {
                    int imagefilelenth = PostedFile.ContentLength;
                    byte[] imgarray = new byte[imagefilelenth];
                    HttpPostedFile image = PostedFile;
                    image.InputStream.Read(imgarray, 0, imagefilelenth);
                    int result = r.altaImages(idInm, imgarray);
                    if (result <= 0)
                        Response.Write("<script>alert('Hubo un error al subir foto"+i+"');</script>");                    

                }

            }
      
            Session["idInm"] = null;
            Response.Redirect("IndexClient.aspx");

        }

    }
}