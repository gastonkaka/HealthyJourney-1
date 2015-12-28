using System.Web;
using System.Web.Optimization;

namespace HealthyJourney.Angular
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/Jqueryval/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                     "~/Scripts/Angular/angular.js",
                     "~/Scripts/Angular/angular-route.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-social.css",
                      "~/Content/owl.carousel.css",
                      "~/Content/color-blue.css",
                      "~/Content/styles.css",
                      "~/Content/card.css",
                      "~/Content/layerslider.css",
                      "~/Content/owl.theme.css",
                      "~/Content/owl.transitions.css",
                       "~/Content/animate.css",
                      "~/Content/flexslider.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/owl").Include(
                      "~/Scripts/owl.carousel.min.js",
                       "~/Scripts/isotope.pkgd.min.js",
                      "~/Scripts/wow.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/accordion").Include(
          "~/Scripts/Accordion/jquery.ui.accordion.min.js",
          "~/Scripts/Accordion/jquery.ui.core.min.js",
          "~/Scripts/Accordion/jquery.ui.widget.min.js",
          "~/Scripts/Accordion/jquery.ui.tabs.min.js",
          "~/Scripts/Accordion/jquery-ui-tabs-rotate.js"));

           
          


            bundles.Add(new ScriptBundle("~/bundles/gmaps").Include(
                        "~/Scripts/gmaps.js"));

            bundles.Add(new ScriptBundle("~/bundles/layerslider").Include(
                       "~/Scripts/layerslider.kreaturamedia.jquery.js",
                       "~/Scripts/layerslider.transitions.js"));

           
        }
    }
}
