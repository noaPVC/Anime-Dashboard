using Anime_Dashboard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.ViewModel.Items
{
    public class MovieShot
    {
        public string ShotImageSource { get; set; }

        public string DisplayedLength { get; set; }

        public MovieShot() { }

        public MovieShot(string shotImageSource, int lengthInMinutes)
        {
            ShotImageSource = shotImageSource;
            DisplayedLength = UtilGeneral.FormatLength(lengthInMinutes);
        }

        public override bool Equals(object? obj)
        {
            return obj is MovieShot shot &&
                   ShotImageSource == shot.ShotImageSource &&
                   DisplayedLength == shot.DisplayedLength;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ShotImageSource, DisplayedLength);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
