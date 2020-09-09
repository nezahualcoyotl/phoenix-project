using System.Web.Optimization;

namespace BackstageMusic
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/theme/css").Include(
                "~/Content/css/theme.css",
                "~/Content/css/default.css",
                "~/Content/css/custom.css"
            ));

            bundles.Add(new StyleBundle("~/vendor/css").Include(
                "~/Content/vendor/bootstrap/css/bootstrap.css",
                "~/Content/vendor/animate/animate.css",
                "~/Content/vendor/font-awesome/css/all.min.css",
                "~/Content/vendor/magnific-popup/magnific-popup.css",
                "~/Content/vendor/bootstrap-datepicker/css/bootstrap-datepicker3.css"
            ));

            bundles.Add(new StyleBundle("~/datatables/css").Include(
                "~/Content/vendor/select2/css/select2.css",
                "~/Content/vendor/select2-bootstrap-theme/select2-bootstrap.min.css",
                "~/Content/vendor/datatables/media/css/dataTables.bootstrap4.css"
            ));

            bundles.Add(new ScriptBundle("~/modernizr/js").Include(
                "~/Content/vendor/modernizr/modernizr.js"
            ));

            bundles.Add(new ScriptBundle("~/theme/js").Include(
                "~/Content/js/theme.js",
                "~/Content/js/custom.js",
                "~/Content/js/theme.init.js"
            ));

            bundles.Add(new ScriptBundle("~/vendor/js").Include(
                "~/Content/vendor/jquery/jquery.js",
                "~/Content/vendor/jquery-browser-mobile/jquery.browser.mobile.js",
                "~/Content/vendor/popper/umd/popper.min.js",
                "~/Content/vendor/bootstrap/js/bootstrap.js",
                "~/Content/vendor/bootstrap-datepicker/js/bootstrap-datepicker.js",
                "~/Content/vendor/common/common.js",
                "~/Content/vendor/nanoscroller/nanoscroller.js",
                "~/Content/vendor/magnific-popup/jquery.magnific-popup.js",
                "~/Content/vendor/jquery-placeholder/jquery.placeholder.js"
            ));

            bundles.Add(new ScriptBundle("~/datatables/js").Include(
                "~/Content/vendor/select2/js/select2.js",
                "~/Content/vendor/datatables/media/js/jquery.dataTables.min.js",
                "~/Content/vendor/datatables/media/js/dataTables.bootstrap4.min.js",
                "~/Content/vendor/datatables/extras/TableTools/Buttons-1.4.2/js/dataTables.buttons.min.js",
                "~/Content/vendor/datatables/extras/TableTools/Buttons-1.4.2/js/buttons.bootstrap4.min.js",
                "~/Content/vendor/datatables/extras/TableTools/Buttons-1.4.2/js/buttons.html5.min.js",
                "~/Content/vendor/datatables/extras/TableTools/Buttons-1.4.2/js/buttons.print.min.js",
                "~/Content/vendor/datatables/extras/TableTools/JSZip-2.5.0/jszip.min.js",
                "~/Content/vendor/datatables/extras/TableTools/pdfmake-0.1.32/pdfmake.min.js",
                "~/Content/vendor/datatables/extras/TableTools/pdfmake-0.1.32/vfs_fonts.js",
                "~/Content/js/defaults/defaults.datatables.default.js",
                "~/Content/js/defaults/defaults.datatables.row.with.details.js",
                "~/Content/js/defaults/defaults.datatables.tabletools.js"
            ));

            bundles.Add(new ScriptBundle("~/jqueryval").Include(
                "~/Content/vendor/jquery-validation/jquery.validate.js"
            ));
        }
    }
}
