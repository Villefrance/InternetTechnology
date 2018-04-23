using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OurWebsite.Forms
{
    public partial class SignupForm : System.Web.UI.Page
    {
        private string _path = AppDomain.CurrentDomain.BaseDirectory;
        private string _fileName = @"\newsletter_database.txt";

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void SignupBtn_Click(object sender, EventArgs e)
        {

            //Using the streamwriter to create the file and write to it...
            using (System.IO.StreamWriter sw = System.IO.File.CreateText(_path + _fileName))
            {

                sw.WriteLine(NameBox.Text + ":" + MailBox.Text);
            }
            
            Response.Redirect("~/Personas/Us");
        }

    }
}