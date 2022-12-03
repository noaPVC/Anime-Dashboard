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

        public string DisplayedLength { get; set; }

        public EpisodeShot() { }

        public EpisodeShot(string shotImageSource, string episodeName, int episode, int season, int lengthInMinutes)
        {
            Season = season;
            Episode = episode;
            ShotImageSource = shotImageSource;
            EpisodeName = episodeName;
            DisplayedLength = FormatLength(lengthInMinutes);

            DisplayTitle = $"S{Season}/EP{Episode} - {EpisodeName}";
        }

        public string FormatLength(int length)
        {
            int hours = length / 60;
            int minutes = length % 60;

            if (length >= 60)
            {
                if(minutes != 0)
                    return $"{hours}h {minutes} min";

                return $"{hours}h";
            }

            return $"{minutes} min";
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
