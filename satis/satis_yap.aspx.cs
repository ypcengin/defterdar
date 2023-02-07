using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.satis
{
    public partial class satis_yap : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urunAdiniGetir = (from x in db.URUN select new { x.ID, x.URUN_AD }).ToList();
                DropDownList1.DataTextField = "URUN_AD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataSource = urunAdiniGetir;
                DropDownList1.DataBind();

                var personelAdinSoyadiniGetir = (from x in db.PERSONEL select new { x.ID,  personel_ad_soyad= x.AD + " " +x.SOYAD  }).ToList();
                DropDownList2.DataTextField = "personel_ad_soyad";
                DropDownList2.DataValueField = "ID";
                DropDownList2.DataSource = personelAdinSoyadiniGetir;
                DropDownList2.DataBind();

                var musteriAdinSoyadiniGetir = (from x in db.MUSTERI select new { x.ID, musteri_ad_soyad = x.AD + " " + x.SOYAD }).ToList();
                DropDownList3.DataTextField = "musteri_ad_soyad";
                DropDownList3.DataValueField = "ID";
                DropDownList3.DataSource = musteriAdinSoyadiniGetir;
                DropDownList3.DataBind();
                               
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SATIS s = new SATIS();
            s.URUN_ID = int.Parse(DropDownList1.SelectedValue);
            s.PERSONEL_ID = int.Parse(DropDownList2.SelectedValue);
            s.MUSTERI_ID = int.Parse(DropDownList3.SelectedValue);
            s.FIYAT = decimal.Parse(txtSatisFiyat.Text);

            db.SATIS.Add(s);
            db.SaveChanges();
            Response.Redirect("satis.aspx");
        }
    }
}