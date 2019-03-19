using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace QLBH
{
    public partial class DangNhap : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var form = (HtmlForm) Master.FindControl("form1");
                form.ID = "login";
                form.Method = "POST";
            }
        }
    }
}