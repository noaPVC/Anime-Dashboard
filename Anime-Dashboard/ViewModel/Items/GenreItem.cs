using Anime_Dashboard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.ViewModel
{
    public class GenreItem : ViewModelBase
    {
        public string GenreName { get; set; }

        public string ImagePresenterSource { get; set; }

        public GenreItem(string genreName, string imagePresenterSource)
        {
            GenreName = genreName;
            ImagePresenterSource = imagePresenterSource;
        }

        public override bool Equals(object? obj)
        {
            return obj is GenreItem item &&
                   GenreName == item.GenreName &&
                   ImagePresenterSource == item.ImagePresenterSource;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GenreName, ImagePresenterSource);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
