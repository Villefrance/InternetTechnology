using OurWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurWebsite.Forms
{
    public partial class EditPersonas : System.Web.UI.Page
    {

        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private string _fileName = @"\persona_database.txt";
        IList<Persona> personas = new List<Persona>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
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

                Repeater1.DataSource = personas;
                Repeater1.DataBind();
            }
        }
    

    protected void SaveBtn_Click(object sender, EventArgs e)
        {
            personas.Clear();
            foreach (RepeaterItem persona in Repeater1.Items)
            {
                TextBox nameBox = (TextBox)persona.FindControl("NameBox");
                TextBox descBox = (TextBox)persona.FindControl("DescBox");
                TextBox ageBox = (TextBox)persona.FindControl("AgeBox");
                TextBox eduBox = (TextBox)persona.FindControl("EduBox");
                personas.Add(new Persona() {Name=nameBox.Text, Age=Int16.Parse(ageBox.Text), Description=descBox.Text, Education=eduBox.Text});
            }

            //Using the streamwriter to create the file and write to it...
            using (System.IO.StreamWriter sw = System.IO.File.CreateText(_path + _fileName))
            {
                foreach (Persona persona in personas)
                {
                    sw.WriteLine(persona.Education + ":" + persona.Age + ":" + persona.Description + ":" + persona.Name);
                }
            }

            Response.Redirect("~/Personas/Us");
        }


    }
}