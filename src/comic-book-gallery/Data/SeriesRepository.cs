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

            }

            return seriestoReturn;
        }



    }
}