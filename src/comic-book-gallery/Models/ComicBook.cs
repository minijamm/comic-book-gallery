using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comic_book_gallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public  Series Series { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set;  }

        public string DisplayText
        {
            get
            {
                return Series.Title + " #" + IssueNumber;
            }
        }

        //series-title-issuenumber.jpg
        public string CoverImageFilename
        {
            get
            {
                return Series.Title.Replace(" ",  "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
           

    }
}