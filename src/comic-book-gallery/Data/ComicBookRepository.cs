using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comic_book_gallery.Models;

namespace comic_book_gallery.Data
{
    public class ComicBookRepository
    {
        



    public ComicBook[] GetComicBooks()
        {
            return Data.ComicBooks;
        }

        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in Data.ComicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }
              
            return comicBookToReturn;
        }
    }
}