using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string seriesTitle;
        public string SeriesTitle
        {
            get { return seriesTitle; }
            set { seriesTitle = value; }
        }

        private int issueNumber;
        public int IssueNumber
        {
            get { return issueNumber; }
            set { issueNumber = value; }
        }

        private string description;
        public string DescriptionHtml
        {
            get { return description; }
            set { description = value; }
        }

        private Artist[] artists;
        public Artist[] Artists
        {
            get { return artists; }
            set { artists = value; }
        }

        private bool favorite;
        public bool Favorite
        {
            get { return favorite; }
            set { favorite = value; }
        }



    }
}