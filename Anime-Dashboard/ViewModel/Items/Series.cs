using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public class Series : BaseMedia
    {
        public bool Completed { get; set; }

        /// <summary>
        /// Length => Amount of seasons. <br></br>
        /// Index Value => Amount of episodes for that season.
        /// </summary>
        public List<int> Seasons { get; set; }

        public ObservableCollection<EpisodeShot> Shots { get; set; }

        public Series() {}

        public Series(string name, string coverImageSource, DateTime releaseDate, FSK fSK, decimal rating, string description, string logoImageSource, string bannerImageSource, ObservableCollection<Genre> genres, ObservableCollection<Character> characters, bool completed, List<int> seasons, ObservableCollection<EpisodeShot> shots, bool isSeries) : base(name, coverImageSource, releaseDate, fSK, rating, description, logoImageSource, bannerImageSource, genres, characters, isSeries)
        {
            Completed = completed;
            Seasons = seasons;
            Shots = shots;
        }
    }
}
