using comic_book_gallery.Data;
using comic_book_gallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {

        private ComicBookRepository _comicBookReposity = null;

        public ComicBooksController()
        {
            _comicBookReposity = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var comicBook = _comicBookReposity.GetComicBook(id.Value);
            
            
            
            return View(comicBook);

        }
    }
}