using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventorySystem.Controllers
{
    public class SaleController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Sales";

            return View();
        }
        public ActionResult Info() {

            return View();
        }

    }
}
