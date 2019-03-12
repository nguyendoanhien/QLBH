using System;
using System.Web;
using System.Web.Routing;
using MyUltilities;

namespace QLBH
{
    public class Global : HttpApplication
    {
        private void Application_End(object sender, EventArgs e)
        {
            Application["TruyCapHienTai"] = (int) Application["TruyCapHienTai"] + 1;
        }

        private void Application_Error(object sender, EventArgs e)
        {
        }

        private void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application["TruyCapTatCa"] = 0;
            Application["TruyCapHienTai"] = 0;
            Application["TruyCapTatCa"] = (int) Application["TruyCapTatCa"] + 1;
        }

        private void Session_End(object sender, EventArgs e)
        {
            Application["TruyCapHienTai"] = (int) Application["TruyCapHienTai"] - 1;
            Session["CartSession"] = null;
        }

        private void Session_Start(object sender, EventArgs e)
        {
            Application["TruyCapHienTai"] = (int) Application["TruyCapHienTai"] + 1;
            Session["CartSession"] = Cart.GetIpAddress();
        }
    }
}