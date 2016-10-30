using chuongnh_shop.CodeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            CurrentController.currentController = "Product";
            return View();
        }
        // GET: Product
        public ActionResult Detail()
        {
            CurrentController.currentController = "Product";
            return View();
        }
    }
}