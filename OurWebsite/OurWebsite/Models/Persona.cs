using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OurWebsite.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Education { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class PerDBContext : DbContext
    {
        // PerDBContext connection can be set in the Web.config file. If not set,
        // EntityFramework will create localDB databse in user's directory with the full name of the DbContext class.
        public PerDBContext() { }
        public DbSet<Persona> Personas { get; set; }
    }
}