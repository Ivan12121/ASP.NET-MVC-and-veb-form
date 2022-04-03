using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class ShowDataBaseTableController : Controller
    {
        AllContext allCont = new AllContext();
        public ActionResult CustomersTable()
        {
            return View(allCont.Customers);
        }

        public ActionResult OrdersTable()
        {
            return View(allCont.Orders);
        }

        protected override void Dispose(bool disposing)
        {
            allCont.Dispose();
            base.Dispose(disposing);

        }
    }
}