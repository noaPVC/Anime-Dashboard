using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public class Series : BaseSeries
    {
        public string Description { get; set; }

        public string LogoImageSource { get; set; }

        public string BannerImageSource { get; set; }

        public ObservableCollection<Genre> Genres { get; set; }

        public ObservableCollection<EpisodeShot> Shots { get; set; }

        public ObservableCollection<Character> Characters { get; set; }

        public Series() { }

        public Series(string name, string coverImageSource, DateTime releaseDate, List<int> seasons, FSK fsk, MediumType mediumType, decimal rating, bool completed, string description, string logoImageSource, string bannerImageSource, ObservableCollection<Genre> genres, ObservableCollection<EpisodeShot> shots, ObservableCollection<Character> characters) : base(name, coverImageSource, releaseDate, seasons, fsk, mediumType, rating, completed)
        {
            Description = description;
            LogoImageSource = logoImageSource;
            BannerImageSource = bannerImageSource;
            Genres = genres;
            Shots = shots;
            Characters = characters;
        }

        public override bool Equals(object? obj)
        {
            return obj is Series series &&
                   base.Equals(obj) &&
                   Description == series.Description &&
                   BannerImageSource == series.BannerImageSource &&
                   EqualityComparer<ObservableCollection<Genre>>.Default.Equals(Genres, series.Genres) &&
                   EqualityComparer<ObservableCollection<EpisodeShot>>.Default.Equals(Shots, series.Shots) &&
                   EqualityComparer<ObservableCollection<Character>>.Default.Equals(Characters, series.Characters);
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
