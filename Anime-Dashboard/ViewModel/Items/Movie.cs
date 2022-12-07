using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.ViewModel.Items
{
    public class Movie : BaseMedia
    {
        public MovieShot EmbedShot { get; set; }

        public Movie() {}

        public Movie(MovieShot movieShot, string name, string coverImageSource, DateTime releaseDate, FSK fSK, decimal rating, string description, string logoImageSource, string bannerImageSource, ObservableCollection<Genre> genres, ObservableCollection<Character> characters, bool isSeries) : base(name, coverImageSource, releaseDate, fSK, rating, description, logoImageSource, bannerImageSource, genres, characters, isSeries)
        {
            EmbedShot = movieShot;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, EmbedShot);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
