using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class CreateStringTableController : Controller
    {
        // GET: CreateStringTable
        AllContext allcont = new AllContext();
        [HttpGet]
        public ActionResult CreateCustomers()
        {       
            return View();
        }
        [HttpPost]
        public ActionResult CreateCustomers(Customers cust)
        {
            allcont.Entry(cust).State = EntityState.Added;
            allcont.SaveChanges();

            return RedirectToAction("Action");
        }

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
        public ActionResult DeleteConfirmedCust(int id)
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
        public ActionResult DeleteConfirmedOrd(int id)
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



        [HttpGet]
        public ActionResult EditCustomers(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Customers cust = allcont.Customers.Find(id);
            if (cust != null)
            {
                return View(cust);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditCustomers(Customers cust)
        {
            allcont.Entry(cust).State = EntityState.Modified;
            allcont.SaveChanges();
            return RedirectToAction("EditCustomers");
        }

        [HttpGet]
        public ActionResult EditOrders(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Orders ord = allcont.Orders.Find(id);
            if (ord != null)
            {
                return View(ord);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult EditOrders(Orders ord)
        {
            allcont.Entry(ord).State = EntityState.Modified;
            allcont.SaveChanges();
            return RedirectToAction("Action");
        }

        [HttpGet]
        public ActionResult InputIdCustomersEdit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputIdCustomersEdit(string numID)
        {
            return RedirectToAction("EditCustomers/" + numID);
        }

        //

        [HttpGet]
        public ActionResult InputIdOrdersEdit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputIdOrdersEdit(string numID)
        {
            return RedirectToAction("EditOrders/" + numID);
        }

        //

        [HttpGet]
        public ActionResult InputIdCustomersDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputIdCustomersDelete(string numID)
        {
            return RedirectToAction("DeleteCustomers/" + numID);
        }

        //

        [HttpGet]
        public ActionResult InputIdOrdersDelete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InputIdOrdersDelete(string numID)
        {
            return RedirectToAction("DeleteOrders/" + numID);
        }

    }
}