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
        protected int idInm;
        protected void Page_Load(object sender, EventArgs e)
        {
            idInm = Convert.ToInt32(Session["idInm"]);
        }

        protected void btnUp_Click(object sender, EventArgs e)
        {
            Renta r = new Renta();
            if (pic1.HasFile)
            {
                int imagefilelenth = pic1.PostedFile.ContentLength;
                byte[] imgarray = new byte[imagefilelenth];
                HttpPostedFile image = pic1.PostedFile;
                image.InputStream.Read(imgarray, 0, imagefilelenth);
                int result = r.altaImages(idInm, imgarray);                        
                if(result <= 0)
                    Response.Write("<script>alert('Hubo un error al subir foto 1');</script>");
            }
            if (pic2.HasFile)
            {
                int imagefilelenth = pic2.PostedFile.ContentLength;
                byte[] imgarray = new byte[imagefilelenth];
                HttpPostedFile image = pic2.PostedFile;
                image.InputStream.Read(imgarray, 0, imagefilelenth);
                int result = r.altaImages(idInm, imgarray);
                if (result <= 0)
                    Response.Write("<script>alert('Hubo un error al subir foto 2');</script>");
            }
            if (pic3.HasFile)
            {
                int imagefilelenth = pic3.PostedFile.ContentLength;
                byte[] imgarray = new byte[imagefilelenth];
                HttpPostedFile image = pic3.PostedFile;
                image.InputStream.Read(imgarray, 0, imagefilelenth);
                int result = r.altaImages(idInm, imgarray);
                if (result <= 0)
                    Response.Write("<script>alert('Hubo un error al subir foto 3');</script>");
            }
            if (pic4.HasFile)
            {
                int imagefilelenth = pic4.PostedFile.ContentLength;
                byte[] imgarray = new byte[imagefilelenth];
                HttpPostedFile image = pic4.PostedFile;
                image.InputStream.Read(imgarray, 0, imagefilelenth);
                int result = r.altaImages(idInm, imgarray);
                if (result <= 0)
                    Response.Write("<script>alert('Hubo un error al subir foto 4');</script>");
            }
            Session["idInm"] = null;
            Response.Redirect("Index.aspx");

        }
        
    }
}