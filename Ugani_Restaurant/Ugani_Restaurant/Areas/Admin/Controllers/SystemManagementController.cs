using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ugani_Restaurant.Models;

namespace Ugani_Restaurant.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SystemManagementController : Controller
    {

        // GET: Admin/SystemManagement
        UGANI_1Entities db = new UGANI_1Entities();
        public ActionResult Index()
        {
            return View();
        }
       
        
    }
}