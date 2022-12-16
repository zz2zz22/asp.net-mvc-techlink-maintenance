using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aspdotnet_webapp_techlink_maintenance.Models;

namespace aspdotnet_webapp_techlink_maintenance.Controllers
{
    public class SiteController : Controller
    {
        private PCCCDbContext db = new PCCCDbContext();
        // GET: Site
        public ActionResult Index()
        {
            ViewBag.SoThietBi = db.device_Infos.Count();
            return View();
        }
        public ActionResult PCCC()
        {
            return View("_PCCC");
        }
    }
}