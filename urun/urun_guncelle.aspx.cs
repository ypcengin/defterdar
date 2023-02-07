using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.urun
{
    public partial class urun_guncelle : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                var kategoriAdiniGetir = (from x in db.KATEGORI select new { x.ID, x.KATEGORI_AD }).ToList();
                DropDownList1.DataTextField = "KATEGORI_AD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataSource = kategoriAdiniGetir;
                DropDownList1.DataBind();

                int guncellenenId = Convert.ToInt32(Request.QueryString["ID"]);
                var p = db.URUN.Find(guncellenenId);

                txtUrunAd.Text = p.URUN_AD;
                txtMarka.Text = p.URUN_MARKA;
                DropDownList1.SelectedValue = p.KATEGORI_ID.ToString(); // kategori seç
                txtGelisFiyat.Text = p.GELIS_FIYAT.ToString();
                txtSatisFiyat.Text = p.ETIKET_FIYAT.ToString();
                txtStok.Text = p.STOK.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int guncellenecekId = Convert.ToInt32(Request.QueryString["ID"]);
            var p = db.URUN.Find(guncellenecekId);

            p.URUN_AD = txtUrunAd.Text;
            p.URUN_MARKA = txtMarka.Text;
            p.KATEGORI_ID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());  //kategori seç
            p.GELIS_FIYAT = decimal.Parse(txtGelisFiyat.Text);
            p.ETIKET_FIYAT = decimal.Parse(txtSatisFiyat.Text);
            p.STOK = Convert.ToInt32(txtStok.Text);
                                   
            db.SaveChanges();
            Response.Redirect("urun.aspx");
        }
    }
}