using chuongnh_shop.CodeHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            CurrentController.currentController = "Blog";
            return View();
        }
        public ActionResult Detail()
        {
            CurrentController.currentController = "Post";
            return View();
        }
        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            return PartialView();
        }
    }
}