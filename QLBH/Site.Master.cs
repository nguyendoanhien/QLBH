using System;
using System.Web.UI;

namespace QLBH
{
    public partial class SiteMaster : MasterPage
    {
        private void Common()
        {
            if (Session["uid"] == null)
            {
            }
        }

        private void GetCartItem()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}