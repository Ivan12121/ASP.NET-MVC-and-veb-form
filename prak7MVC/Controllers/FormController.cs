using prak7MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak7MVC.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        AllContext allcont = new AllContext();
        [HttpGet]
        public ActionResult CreateGuest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateGuest(Guests cust)
        {
            string emGuests = cust.email;
            foreach (Guests guests in allcont.guests)
            {
                if(guests.email == emGuests)
                {
                    return RedirectToAction("/Home/index");
                }
                
                else {
                    allcont.Entry(cust).State = EntityState.Added;
                }
            }
            allcont.SaveChanges();
            return RedirectToAction("CreateGuest");
        }
    }
}