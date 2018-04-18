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
            di = new System.IO.DirectoryInfo(folder);

            foreach (var file in di.EnumerateFiles("*.jpg", System.IO.SearchOption.TopDirectoryOnly))
            {
                string _path = String.Concat(folder, file.Name);
                string _absolute = _path.Replace(@"\", "/");
                var p = new Photo() { Path = _absolute, Description = System.IO.Path.GetFileNameWithoutExtension(file.Name) };
                Add(p);
            }
        }

        
    }
}