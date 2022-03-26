using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class DeleteOrdersController : Controller
    {
        AllContext allcont = new AllContext();
        [HttpGet]
        public ActionResult DeleteOrders(int id)
        {
            Orders o = allcont.Orders.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            return View(o);
        }
        [HttpPost, ActionName("DeleteOrders")]
        public ActionResult DeleteConfirmed(int id)
        {
            Orders o = allcont.Orders.Find(id);
            if (o == null)
            {
                return HttpNotFound();
            }
            allcont.Orders.Remove(o);
            allcont.SaveChanges();
            return RedirectToAction("Action");
        }
    }
}