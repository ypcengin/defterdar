using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP
{
    public partial class kategori_ekle : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KATEGORI k = new KATEGORI();
            k.KATEGORI_AD = TextBox1.Text;
            db.KATEGORI.Add(k);
            db.SaveChanges();
        }
    }
}