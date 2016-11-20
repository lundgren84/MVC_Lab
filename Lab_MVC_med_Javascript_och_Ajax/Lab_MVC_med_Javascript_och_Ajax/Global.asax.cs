﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Lab_MVC_med_Javascript_och_Ajax
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
          
        }
        protected void Application_Error(object sender, EventArgs e)
        {
          
        }
        protected void Application_End()//När??
        {
            System.Diagnostics.Debugger.Break();
        }
    }
}
