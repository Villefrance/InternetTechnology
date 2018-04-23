using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurWebsite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult UploadPicture()
        {
            return View();
        }

        public ActionResult ChangePersona()
        {
            return View();
        }
    }
}