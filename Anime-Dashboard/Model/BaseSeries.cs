using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;

namespace Anime_Dashboard.Model
{
    public abstract class BaseSeries
    {
        public string Name { get; set; }

        public string CoverImageSource { get; set; }

        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Length => Amount of seasons. <br></br>
        /// Index Value => Amount of episodes for that season.
        /// </summary>
        public List<int> Seasons { get; set; }

        public FSK FSK { get; set; }

        public MediumType MediumType { get; set; }

        public decimal Rating { get; set; }

        public BaseSeries() { }

        public BaseSeries(string name, string coverImageSource, DateTime dateTime, List<int> seasons, FSK fsk, MediumType mediumType, decimal rating)
        {
            Name = name;
            CoverImageSource = coverImageSource;
            ReleaseDate = dateTime;
            Seasons = seasons;
            FSK = fsk;
            MediumType = mediumType;
            Rating = rating;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseSeries series &&
                   Name == series.Name &&
                   CoverImageSource == series.CoverImageSource &&
                   ReleaseDate == series.ReleaseDate &&
                   EqualityComparer<List<int>>.Default.Equals(Seasons, series.Seasons) &&
                   FSK == series.FSK &&
                   MediumType == series.MediumType &&
                   Rating == series.Rating;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, CoverImageSource);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
