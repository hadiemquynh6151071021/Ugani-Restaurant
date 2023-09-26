using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ugani_Restaurant.Models;

namespace Ugani_Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private UGANI_1Entities db = new UGANI_1Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Booking()
        {
            return View(db.LOAIKHONGGIANs.ToList());
        }

        public ActionResult GetTableById(int id)
        {
            List<BANAN> bANANs = db.BANANs.Where(m => m.MAKHONGGIAN == id).ToList();
            return PartialView("_listTable", bANANs);
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