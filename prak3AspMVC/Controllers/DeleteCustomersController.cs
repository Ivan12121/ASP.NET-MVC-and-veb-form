using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    
    public class DeleteCustomersController : Controller
    {
        AllContext allcont = new AllContext();
        [HttpGet]
        public ActionResult DeleteCustomers(int id)
        {
            Customers b = allcont.Customers.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("DeleteCustomers")]
        public ActionResult DeleteConfirmed(int id)
        {
            Customers b = allcont.Customers.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            allcont.Customers.Remove(b);
            allcont.SaveChanges();
            return RedirectToAction("Action");
        }
    }
}