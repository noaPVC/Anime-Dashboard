using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;

namespace Anime_Dashboard.Model
{
    public class Series : BaseSeries
    {
        public string Description { get; set; }

        public string LogoImageSource { get; set; }

        public string BannerImageSource { get; set; }

        public List<Genre> Genres { get; set; }

        public List<string> ShotsSources { get; set; }

        public List<Character> Characters { get; set; }

        public Series() { }

        public Series(string name, string coverImageSource, DateTime releaseDate, List<int> seasons, FSK fsk, MediumType mediumType, decimal rating, bool completed, string description, string logoImageSource, string bannerImageSource, List<Genre> genres, List<string> shotsSources, List<Character> characters) : base(name, coverImageSource, releaseDate, seasons, fsk, mediumType, rating, completed)
        {
            Description = description;
            LogoImageSource = logoImageSource;
            BannerImageSource = bannerImageSource;
            Genres = genres;
            ShotsSources = shotsSources;
            Characters = characters;
        }

        public override bool Equals(object? obj)
        {
            return obj is Series series &&
                   base.Equals(obj) &&
                   Description == series.Description &&
                   BannerImageSource == series.BannerImageSource &&
                   EqualityComparer<List<Genre>>.Default.Equals(Genres, series.Genres) &&
                   EqualityComparer<List<string>>.Default.Equals(ShotsSources, series.ShotsSources) &&
                   EqualityComparer<List<Character>>.Default.Equals(Characters, series.Characters);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
