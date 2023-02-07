using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP.musteri
{
    public partial class musteri : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var liste = db.MUSTERI.ToList();
            Repeater1.DataSource= liste;
            Repeater1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            MUSTERI m = new MUSTERI();
            m.AD = TextBox1.Text;
            m.SOYAD= TextBox2.Text;
            m.ACIK_ADRES= TextBox3.Text;
            db.MUSTERI.Add(m);
            db.SaveChanges();
            Response.Redirect("musteri.aspx");
        }
    }
}