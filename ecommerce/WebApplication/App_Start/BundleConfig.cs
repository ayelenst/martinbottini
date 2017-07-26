﻿using System.Web;
using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                           "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/respond.js",
                        "~/Scripts/gridmvc.js",
                         "~/Scripts/owl.carousel.js",
                      "~/Scripts/skyicons.js", 
                      "~/Scripts/custom.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/font-awesome.min.css",
                       "~/Content/Gridmvc.css",
                      "~/Content/custom.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/ecommerce").Include(

                      "~/Areas/Ecommerce/Content/core.css",
                      "~/Areas/Ecommerce/Content/main.css",
                      "~/Areas/Ecommerce/Content/chosen.min.css",
                      "~/Areas/Ecommerce/Content/owl*",
                      "~/Areas/Ecommerce/Content/site.css"));
        }
    }
}
