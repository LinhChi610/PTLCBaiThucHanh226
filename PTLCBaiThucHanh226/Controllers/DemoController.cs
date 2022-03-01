using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTLCBaiThucHanh226.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }
        [HttpPost]

        public ActionResult Index(String Masinhvien, string HoTensinhvien)
        {
            ViewBag.Message = Masinhvien + "   " + HoTensinhvien;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}