﻿using Microsoft.Practices.Unity;
using Repository;
using Service;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Initialize IoC container/Unity
            Bootstrapper.Initialise();
            //Register our custom controller factory
            ControllerBuilder.Current.SetControllerFactory(typeof(ControllerFactory));
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            HttpContext.Current.Session.Add("UserId", null);
        }
       
    }
}
