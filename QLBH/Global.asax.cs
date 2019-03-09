﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using MyUltilities;
namespace QLBH
{
    public class Global : HttpApplication
    {
        
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application["TruyCapTatCa"] = 0;
            Application["TruyCapHienTai"] = 0;
            Application["TruyCapTatCa"] = (int)Application["TruyCapTatCa"] + 1;
        }
        void Application_End(object sender, EventArgs e)
        {
            Application["TruyCapHienTai"] = (int)Application["TruyCapHienTai"] + 1;
           
        }

        void Application_Error(object sender, EventArgs e)
        {

        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["TruyCapHienTai"] = (int)Application["TruyCapHienTai"] + 1;
            Session["CartSession"] = Cart.GetIpAddress();

        }
        void Session_End(object sender, EventArgs E)
        {
            Application["TruyCapHienTai"] = (int)Application["TruyCapHienTai"] - 1;
            Session["CartSession"] = null;
        }
    }
}