using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public string About1(string id, string name)
        {
            return "ID = " + id + " Name = " + name;
        }
        public string About2()
        {
            return "ID = " + Request.QueryString["id"] + " Name = " + Request.QueryString["name"];
        }
        public ActionResult About3()
        {
            ViewData["id"] = Request.QueryString["id"];
            ViewData["name"] = Request.QueryString["name"];
            return View();
        }
        public ActionResult About4()
        {
            ViewBag.Fruits = new List<string>()
            {
                "Cam","Xoai","Coc","Oi"
            };
            return View();
        }

    }
}
