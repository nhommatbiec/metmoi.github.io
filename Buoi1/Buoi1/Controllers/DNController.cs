using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi1.Controllers
{
    public class DNController : Controller
    {
        //
        // GET: /DN/
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string name, string password)
        {
            if ("yennh".Equals(name) && "123456".Equals(password))
            {
                Session["user"] = new Models.User() { login=name,UserName="Nguyễn Hải Yến"};
            }
            //chuyển hướng trang
            return RedirectToAction("Index","HomeDN");
        }
        [HttpPost]
        public ActionResult DangKy(string name, string password, string rt_password)
        {
            if (name.Length >= 5 && password.Length >= 6 && rt_password.Equals(password))
                return RedirectToAction("DangNhap", "DN");
            else
                return View();
        }
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index", "HomeDN");
        }
    }
}
