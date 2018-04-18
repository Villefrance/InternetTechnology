using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OurWebsite.Models
{
    public class PhotoModel : List<Photo>
    {
        private System.IO.DirectoryInfo di;

        public PhotoModel(string folder)
        {
            string path = HttpContext.Current.Server.MapPath(folder);
            di = new System.IO.DirectoryInfo(path);

            foreach (var file in di.EnumerateFiles("*.jpg", System.IO.SearchOption.TopDirectoryOnly))
            {
                var p = new Photo() { Path = String.Concat(folder, file.Name), Description = System.IO.Path.GetFileNameWithoutExtension(file.Name) };
                Add(p);
            }
        }

        
    }
}