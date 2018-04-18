using OurWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurWebsite.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult Gallery()
        {
            string folder = "~/Photos/";
            
            return View(new PhotoModel(folder));
        }
    }
}