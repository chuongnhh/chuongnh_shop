using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace chuongnh_shop.Controllers
{
    public class Error500Controller : Controller
    {
        // GET: Error500
        public ActionResult Index()
        {
            return View();
        }
    }
}