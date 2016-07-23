using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comic_book_gallery.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHTML { get; set; }
        public ComicBook[] Issues { get; set; }
    }
}