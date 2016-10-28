using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace chuongnh_shop.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // client
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                         
                         ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                         
                         ));

            // Code removed for clarity.
            BundleTable.EnableOptimizations = true;
        }
    }
}