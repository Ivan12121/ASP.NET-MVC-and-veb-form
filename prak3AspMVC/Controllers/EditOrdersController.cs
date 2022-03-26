using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class EditOrdersController : Controller
    {

        AllContext cont = new AllContext();
        [HttpGet]
        public ActionResult EditOrders(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Orders ord = cont.Orders.Find(id);
            if (ord != null)
            {
                return View(ord);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditCustomers(Orders ord)
        {
            cont.Entry(ord).State = EntityState.Modified;
            cont.SaveChanges();
            return RedirectToAction("Action");
        }
    }
}