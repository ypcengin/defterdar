using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TCRAPP.Entity;

namespace TCRAPP
{
    public partial class kategori : System.Web.UI.Page
    {
        E_TICARET_MAGAZAEntities db = new E_TICARET_MAGAZAEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.KATEGORI.ToList();
            Repeater1.DataSource = degerler;
            Repeater1.DataBind();
            
        }
    }
}