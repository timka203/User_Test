using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_exam.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DB_model dB_Model = new DB_model();
            dB_Model.Test_info.Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}