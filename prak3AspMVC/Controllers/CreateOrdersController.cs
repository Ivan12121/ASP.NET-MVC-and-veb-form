using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class CreateOrdersController : Controller
    {
        // GET: CreateOrders
        AllContext allcont = new AllContext();
        [HttpGet]
        public ActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateOrder(Orders ord)
        {
            allcont.Entry(ord).State = EntityState.Added;
            allcont.SaveChanges();

            return RedirectToAction("Action");
        }
    }
}
