using System.Web;
using System.Web.Optimization;

namespace HospitalManagement
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
                       "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/clockpicker.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/DataTables/jquery.datatables.js",
                      "~/Scripts/DataTables/datatables.bootstrap.js",
                      "~/Scripts/DataTables/dataTables.buttons.js",
                        "~/Scripts/DataTables/jszip.js",
                      "~/Scripts/DataTables/buttons.html5.js",
                        "~/Scripts/DataTables/buttons.print.js",
                      "~/Scripts/DataTables/pdfmake.js",
                      "~/Scripts/DataTables/vfs_fonts.js",
                    "~/Scripts/raphael.min.js",
                    "~/Scripts/jquery-ui-1.12.1.min.js",
                      "~/Scripts/bootbox.min.js",
                      "~/Scripts/venders/iCheck/icheck.min.js",
                      "~/Scripts/vendors/autosize",
                      "~/Scripts/vendors/select2.full.min.js",
                      "~/Scripts/typeahead.bundle.js",
                      "~/Scripts/toastr.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/css/nprogress.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/custom.css"));
        }
    }
}
