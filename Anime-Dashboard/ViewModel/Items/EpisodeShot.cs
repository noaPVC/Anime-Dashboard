using Anime_Dashboard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.ViewModel
{
    public class EpisodeShot : ViewModelBase
    {
        public int Season { get; set; }

        public int Episode { get; set; }

        public string ShotImageSource { get; set; }

        public string EpisodeName { get; set; }

        public string DisplayTitle { get; }

        public EpisodeShot(string shotImageSource, string episodeName, int episode, int season, string displayTitle)
        {
            Season = season;
            Episode = episode;
            ShotImageSource = shotImageSource;
            EpisodeName = episodeName;

            DisplayTitle = $"S{Season}/EP{Episode}: {EpisodeName}";
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EpisodeName, Episode);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
