using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comic_book_gallery.Models;

namespace comic_book_gallery.Data
{
    public class SeriesRepository
    {
        public Series[] GetSeries()
        {
            return Data.Series;
        }

        public Series GetSeriesDetail(int id)
        {

            Series seriestoReturn = null;

            foreach (var series in Data.Series)
            {

                if (series.Id == id)
                {
                    seriestoReturn = series;
                    break;
                }
            

            }

            if (seriestoReturn != null)
            {
                //return books for this series
                var comicBooks = new ComicBook[0];

                    foreach (var comicBook in Data.ComicBooks)
                {
                    if (comicBook.Series != null && comicBook.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length + 1);
                        comicBooks[comicBooks.Length - 1] = comicBook;
                    }

                    
                }
                seriestoReturn.Issues = comicBooks;
            }

            return seriestoReturn;
        }



    }
}