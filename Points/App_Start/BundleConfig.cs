using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace Points
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/PointApp.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/lib/angular.js"     
                ));

            bundles.Add(new ScriptBundle("~/bundles/controllers")
                .IncludeDirectory("~/Scripts/app/Controllers", "*.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/services")
                .IncludeDirectory("~/Scripts/app/Services", "*.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/directives")
                .IncludeDirectory("~/Scripts/app/Directives", "*.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/fileUpload")
                .IncludeDirectory("~/Scripts/lib/ng-upload", "*.js"));

            //bundles.Add(new ScriptBundle("~/bundles/views")
            //    .IncludeDirectory("~/Scripts/app/Views", "*.html"
            //    ));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                 "~/Content/bootstrap.css",
                 "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Style/css")
                .IncludeDirectory("~/Style", "*.css"));
        }
    }
}
