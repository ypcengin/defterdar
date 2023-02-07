using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP
{
    public partial class kategori_sil : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int silinecek_id = Convert.ToInt32(Request.QueryString["ID"]);
            var deger = db.KATEGORI.Find(silinecek_id);
            db.KATEGORI.Remove(deger);
            db.SaveChanges();
            Response.Redirect("kategori.aspx");
        }
    }
}