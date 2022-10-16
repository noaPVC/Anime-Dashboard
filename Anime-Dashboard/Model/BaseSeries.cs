using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.Model
{
    public class BaseSeries
    {
        public string Name { get; set; }

        public string CoverImageSource { get; set; }

        /// <summary>
        /// Length => Amount of seasons. <br></br>
        /// Index Value => Amount of episodes for that season.
        /// </summary>
        public List<int> Seasons { get; set; }

        public int FSK { get; set; }

        public decimal Rating { get; set; }

        public BaseSeries(string name, string coverImageSource, List<int> seasons, int fSK, decimal rating)
        {
            Name = name;
            CoverImageSource = coverImageSource;
            Seasons = seasons;
            FSK = fSK;
            Rating = rating;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseSeries series &&
                   Name == series.Name &&
                   CoverImageSource == series.CoverImageSource &&
                   EqualityComparer<List<int>>.Default.Equals(Seasons, series.Seasons) &&
                   FSK == series.FSK &&
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
