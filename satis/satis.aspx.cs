using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.satis
{
    public partial class satis : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            // var satisListesi = db.SATIS.ToList(); bütün listeyi tabloda olduğu gibi getirir.
            var satisListesi = (from x in db.SATIS
                                select new
                                 {
                                     x.ID,
                                     x.URUN.URUN_AD,
                                     personelAdSoyadBilgisi = x.PERSONEL.AD + " " + x.PERSONEL.SOYAD,
                                     musteriAdSoyadBilgisi = x.MUSTERI.AD + " " + x.MUSTERI.SOYAD,
                                     x.FIYAT
                                 }).ToList();
            Repeater1.DataSource = satisListesi;
            Repeater1.DataBind();
        }
    }
}