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
        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private string _fileName = @"\persona_database.txt";

        // GET: Personas/index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Us()
        {
            IList<Persona> personas = new List<Persona>();

            //Need to check if the file exists otherwise an exception is thrown.
            if (System.IO.File.Exists(_path + _fileName))
            {

                using (System.IO.StreamReader sr = System.IO.File.OpenText(_path + _fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //The format of a stored spersona is a line like: value1:value2:...  this is the reasoning for splitting by ":" 
                        string[] protoypePersona = line.Split(':');

                        personas.Add(new Persona() { Education = protoypePersona[0], Age = Int16.Parse(protoypePersona[1]), Description = protoypePersona[2], Name = protoypePersona[3] });

                    }
                }

            }


            //Persona emil = new Persona() { Education = "Software Engineering", Age = 23, Description = "Hello there, I like to party and make smooth tender love with my wife.", Name = "Emil" };
            //Persona kennet = new Persona() { Education = "Software Engineering", Age = 25, Description = "Hello there, I like to shit and EAT all day long.", Name = "Kennet" };
            //personas.Add(emil);
            //personas.Add(kennet);
            return View(personas);
        }
    }
}