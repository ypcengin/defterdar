using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;
using TCRAPP.Urun;

namespace TCRAPP.urun
{
    public partial class urun_sil : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db= new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int urunGuncellencekId = Convert.ToInt32(Request.QueryString["ID"]);
            var hangiUrun = db.URUN.Find(urunGuncellencekId);
            hangiUrun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("urun.aspx");
        }
    }
}