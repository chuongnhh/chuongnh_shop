using chuongnh_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace chuongnh_shop.Areas.Admin.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Account account)
        {
            if (Membership.ValidateUser(account.Username, account.Password))
            {
                FormsAuthentication.SetAuthCookie(account.Username, false);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Đăng nhập không thành công.");
            }
            return View("Index");
        }
        public ActionResult Logout(Account account)
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}