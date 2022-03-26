using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using prak3AspMVC.Models;

namespace prak3AspMVC.Controllers
{
    public class ShowCustomersDataBaseController : Controller
    {
        
        AllContext CustCont = new AllContext();

        public ActionResult CustomersDataBase()
        {
            return View(CustCont.Customers);
        }

        protected override void Dispose(bool disposing)
        {
            CustCont.Dispose();
            base.Dispose(disposing);
        }
    }
}