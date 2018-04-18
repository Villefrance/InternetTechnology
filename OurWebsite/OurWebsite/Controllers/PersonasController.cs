using OurWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OurWebsite.Controllers
{
    public class PersonasController : Controller
    {
        // GET: Personas/index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Us()
        {
            IList<Persona> personas = new List<Persona>(); 
            Persona emil = new Persona() { Education = "Software Engineering", Age = 23, Description = "Hello there, I like to party and make smooth tender love with my wife.", Name = "Emil" };
            Persona kennet = new Persona() { Education = "Software Engineering", Age = 25, Description = "Hello there, I like to shit and EAT all day long.", Name = "Kennet" };
            personas.Add(emil);
            personas.Add(kennet);
            return View(personas);
        }
    }
}