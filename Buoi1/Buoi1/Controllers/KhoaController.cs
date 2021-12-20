using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi1.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Khoa/

        public ActionResult Index()
        {
            Models.KhoaModels khoacnttt = new Models.KhoaModels();
            khoacnttt.Message = "FIT-HUFI: HOC TAP - NANG DONG - SANG TAO";
            return View(khoacnttt);
        }

    }
}
