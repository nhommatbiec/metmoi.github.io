using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi1.Controllers
{
    public class HomeDNController : Controller
    {
        //
        // GET: /HomeDN/

        public ActionResult Index()
        {
            if(Session["user"]==null)
                return RedirectToAction("DangNhap", "DN");
            else
                return View();
        }

    }
}
