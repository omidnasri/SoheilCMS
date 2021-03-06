﻿using System.Web;
using System.Web.Optimization;

namespace SoheilCMS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/AdminStyle.css",
                      "~/Content/themes/base/all.css",
                      "~/Content/TagStyle/bootstrap-tagsinput.css",
                      "~/Content/PersianDateTimePicker/PersianDatePicker.min.css"));



            bundles.Add(new StyleBundle("~/Content/Menu").Include(
                      "~/Content/Menu/page.css",
                      "~/Content/Menu/super-panel.css",
                      "~/Content/Menu/accordion-menu.css"));


            bundles.Add(new ScriptBundle("~/bundles/Menu").Include(
                "~/Scripts/Menu/super-panel.js ",
                "~/Scripts/Menu/accordion-menu.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/Admin").Include(
               "~/Scripts/Admin/AdminScript.js"

               ));


            bundles.Add(new ScriptBundle("~/bundles/Pager").Include(
             "~/Scripts/jquery.pager-1.0.2.min.js",
             "~/Scripts/path.min.js",
             "~/Scripts/AdminPager.js"

             ));

            bundles.Add(new ScriptBundle("~/bundles/CkEditorPart1").Include(
             "~/Scripts/ckeditor/ckeditor.js"

             ));



            bundles.Add(new ScriptBundle("~/bundles/CkEditorPart2").Include(
            "~/Scripts/ckeditor/adapters/jquery.js",
            "~/Scripts/ckeditor/EnableCkEditor.js"
            ));


            bundles.Add(new ScriptBundle("~/bundles/JqueryUi").Include(
            "~/Scripts/jquery-ui-1.11.4.min.js"

            ));

            bundles.Add(new ScriptBundle("~/bundles/TagScript")
                .Include("~/Scripts/TagScript/bootstrap-tagsinput.js"));

            bundles.Add(new ScriptBundle("~/bundles/PersianDateTimePicker")
            .Include("~/Scripts/PersianDateTimePicker/jquery-ui-datetimepicker.min.js")
            .Include("~/Scripts/PersianDateTimePicker/InitPersianDatetime.js"));



        }
    }
}
