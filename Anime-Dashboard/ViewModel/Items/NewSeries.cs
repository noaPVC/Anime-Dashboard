using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;

namespace Anime_Dashboard.ViewModel
{
    public class NewSeries : BaseSeries
    {
        public NewSeries(string name, string coverImageSource, DateTime dateTime, List<int> seasons, FSK fsk, MediumType mediumType, decimal rating, bool completed) : base(name, coverImageSource, dateTime, seasons, fsk, mediumType, rating, completed)
        {
        }
    }
}
