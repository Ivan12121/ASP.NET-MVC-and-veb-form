using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class EditCustomersController : Controller
    {
        // GET: EditCustomers
        AllContext cont = new AllContext();
        [HttpGet]
        public ActionResult EditCustomers(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Customers cust = cont.Customers.Find(id);
            if (cust != null)
            {
                return View(cust);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditCustomers(Customers cust)
        {
            cont.Entry(cust).State = EntityState.Modified;
            cont.SaveChanges();
            return RedirectToAction("Action");
        }
    }
}