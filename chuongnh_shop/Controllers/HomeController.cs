using chuongnh_shop.CodeHelper;
using chuongnh_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Controllers
{
    public class HomeController : Controller
    {
        chuongnh db = new chuongnh();
        // GET: Home
        public ActionResult Index()
        {
            CurrentController.currentController = "Home";
            return View();
        }
        [ChildActionOnly]
        public ActionResult Footer()
        {
            Footer footer = new Footer { Company = "© 2016 chuongnh. All rights reserved." };
            return PartialView(footer);
        }
        [ChildActionOnly]
        public ActionResult Header()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Slider()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult Sidebar()
        {
            return PartialView();
        }
    }
}