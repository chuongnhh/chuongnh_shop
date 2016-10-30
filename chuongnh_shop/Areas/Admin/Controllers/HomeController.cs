using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}