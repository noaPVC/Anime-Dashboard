using Anime_Dashboard.Core;
using Anime_Dashboard.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public abstract class BaseMedia : ViewModelBase
    {
        public string Name { get; set; }

        public string CoverImageSource { get; set; }

        public DateTime ReleaseDate { get; set; }

        public FSK FSK { get; set; }

        public decimal Rating { get; set; }

        public string Description { get; set; }

        public string LogoImageSource { get; set; }

        public string BannerImageSource { get; set; }

        public ObservableCollection<Genre> Genres { get; set; }

        public ObservableCollection<Character> Characters { get; set; }

        public bool IsSeries { get; set; }

        public BaseMedia() { }

        protected BaseMedia(string name, string coverImageSource, DateTime releaseDate, FSK fSK, decimal rating, string description, string logoImageSource, string bannerImageSource, ObservableCollection<Genre> genres, ObservableCollection<Character> characters, bool isSeries)
        {
            Name = name;
            CoverImageSource = coverImageSource;
            ReleaseDate = releaseDate;
            FSK = fSK;
            Rating = rating;
            Description = description;
            LogoImageSource = logoImageSource;
            BannerImageSource = bannerImageSource;
            Genres = genres;
            Characters = characters;
            IsSeries = isSeries;
        }

        public override bool Equals(object? obj)
        {
            return obj is BaseMedia media &&
                   Name == media.Name &&
                   CoverImageSource == media.CoverImageSource &&
                   ReleaseDate == media.ReleaseDate &&
                   FSK == media.FSK &&
                   Rating == media.Rating &&
                   Description == media.Description &&
                   LogoImageSource == media.LogoImageSource &&
                   BannerImageSource == media.BannerImageSource &&
                   EqualityComparer<ObservableCollection<Genre>>.Default.Equals(Genres, media.Genres) &&
                   EqualityComparer<ObservableCollection<Character>>.Default.Equals(Characters, media.Characters) &&
                   IsSeries == media.IsSeries;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
