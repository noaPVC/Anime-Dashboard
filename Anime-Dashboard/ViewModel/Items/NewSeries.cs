using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public class NewSeries : BaseMedia
    {
        public NewSeries(string name, string coverImageSource, DateTime releaseDate, FSK fSK, decimal rating, string description, string logoImageSource, string bannerImageSource, ObservableCollection<Genre> genres, ObservableCollection<Character> characters, bool isSeries) : base(name, coverImageSource, releaseDate, fSK, rating, description, logoImageSource, bannerImageSource, genres, characters, isSeries)
        {
        }
    }
}
