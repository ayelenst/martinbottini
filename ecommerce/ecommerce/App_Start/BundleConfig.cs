﻿using System.Web;
using System.Web.Optimization;

namespace ecommerce
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
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/owl.carousel.min.js",
                 "~/Scripts/chosen.jquery.js",
                 "~/Scripts/chosen.proto.js",
                 "~/Scripts/gridmvc.js",
                    "~/Scripts/layout.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(

                      "~/Content/core.css",
                      "~/Content/animate.css",
                      "~/Content/custommenu.css",
                      "~/Content/main.css",
                      "~/Content/chosen.min.css",
                      "~/Content/owl*",
                       "~/Content/font-awesome.min.css",
                       "~/Content/Gridmvc.css",
                      "~/Content/site.css"));
        }
    }
}
