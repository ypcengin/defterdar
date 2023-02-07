using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.urun
{
    public partial class urun_ekle : System.Web.UI.Page
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            URUN u = new URUN();

            u.URUN_AD = txtUrunAd.Text;
            u.URUN_MARKA = txtMarka.Text;
            u.STOK = Convert.ToInt32(txtStok.Text);
            u.KATEGORI_ID = Convert.ToInt32(DropDownList1.SelectedValue);
            u.GELIS_FIYAT = decimal.Parse(txtGelisFiyat.Text);
            u.ETIKET_FIYAT = decimal.Parse(txtSatisFiyat.Text);

            db.URUN.Add(u);
            db.SaveChanges();
            Response.Redirect("urun.aspx");
        }
    }
}