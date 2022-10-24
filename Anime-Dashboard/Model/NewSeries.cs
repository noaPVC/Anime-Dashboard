using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;

namespace Anime_Dashboard.Model
{
    public class NewSeries : BaseSeries
    {
        public NewSeries(string name, string coverImageSource, DateTime releaseDate, List<int> seasons, FSK fsk, MediumType mediumType, decimal rating) : base(name, coverImageSource, releaseDate, seasons, fsk, mediumType, rating)
        {
        }
    }
}
