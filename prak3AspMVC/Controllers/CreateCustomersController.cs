using prak3AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak3AspMVC.Controllers
{
    public class CreateCustomersController : Controller
    {
        // GET: CreateCustomers
        AllContext allcont = new AllContext();  
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customers cust)
        {
            allcont.Entry(cust).State = EntityState.Added;
            allcont.SaveChanges();

            return RedirectToAction("~Views/Home/Action.cshtml");
        }
    }
}