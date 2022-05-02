using prak7MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prak7MVC.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        AllContext allCont = new AllContext();
        public ActionResult GuestTable()
        {
            return View(allCont.guests);
        }
        protected override void Dispose(bool disposing)
        {
            allCont.Dispose();
            base.Dispose(disposing);

        }
    }
}