using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP
{
    public partial class login : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var kontrol = from x in db.KULLANICI where x.KULLANICI_ADI == TxtKullaniciAd.Text && x.SIFRE == TxtSifre.Text select x;

            if (kontrol.Any())
            {
                Response.Redirect("kategori.Aspx");
            }
            else
            {
                Response.Write("Hatalı Bilgi Girişi");

            }
        }
    }
}