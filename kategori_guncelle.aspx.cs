using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP
{
    public partial class kategori_guncelle : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int guncellenenId = Convert.ToInt32(Request.QueryString["ID"]);
                txtId.Text = guncellenenId.ToString();

                var kategoriAdi = db.KATEGORI.Find(guncellenenId);
                txtAd.Text = kategoriAdi.KATEGORI_AD;
            } 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int guncellenecekId = Convert.ToInt32(Request.QueryString["ID"]);
            var yeniKategoriAdi = db.KATEGORI.Find(guncellenecekId);
            yeniKategoriAdi.KATEGORI_AD = txtAd.Text;
            db.SaveChanges();
            Response.Redirect("kategori.aspx");
        }
    }
}