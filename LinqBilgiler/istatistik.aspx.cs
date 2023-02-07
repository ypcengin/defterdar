using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.LinqBilgiler
{
    public partial class istatistik : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text=db.URUN.Count().ToString();
            Label2.Text = db.MUSTERI.Count().ToString();
            Label3.Text=db.SATIS.Sum(x=>x.FIYAT).ToString();
            Label4.Text = db.KATEGORI.Count().ToString();
            Label5.Text = db.URUN.Count(x=>x.DURUM==true).ToString();
            Label6.Text = db.URUN.Count(x => x.DURUM == false).ToString();
            Label7.Text = (from x in db.URUN orderby x.STOK descending
                           select x.URUN_AD).FirstOrDefault();
        }
    }
}