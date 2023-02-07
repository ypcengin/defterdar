using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.Urun
{
    public partial class urun : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var urunListesi = db.URUN.Where(x => x.DURUM == true).ToList(); // sadece durum bilgisi true olanlar listelendi.
            // var urunListesi = db.URUN.ToList(); // bütün kayıtlar listelendi
            var urunListesi = (from x in db.URUN
                               where x.DURUM==true
                           select new
                           {
                               x.ID,
                               x.URUN_AD,
                               x.URUN_MARKA,
                               x.KATEGORI.KATEGORI_AD,
                               x.GELIS_FIYAT,
                               x.ETIKET_FIYAT,
                               x.STOK
                           }) .ToList();
            Repeater1.DataSource = urunListesi;
            Repeater1.DataBind();
        }
    }
}