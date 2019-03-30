using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Artist
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string role;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

    }
}