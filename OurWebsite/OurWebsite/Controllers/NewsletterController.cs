using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurWebsite.Controllers
{
    public class NewsletterController : Controller
    {
        // GET: Newsletter
        public ActionResult SignUp()
        {
            return View();
        }
    }
}