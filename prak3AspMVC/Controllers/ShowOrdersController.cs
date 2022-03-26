using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prak3AspMVC.Models;

namespace prak3AspMVC.Controllers
{
    public class ShowOrdersController : Controller
    {

        AllContext CustCont = new AllContext();

        public ActionResult OrdersDataBase()
        {
            return View(CustCont.Orders);
        }

        protected override void Dispose(bool disposing)
        {
            CustCont.Dispose();
            base.Dispose(disposing);
        }
    }
}