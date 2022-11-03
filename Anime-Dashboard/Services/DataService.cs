using Anime_Dashboard.Enums;
using Anime_Dashboard.Model;
using System;
using System.Collections.Generic;

namespace Anime_Dashboard.Services
{
    public class DataService
    {
        const string IMAGES = "Resources/Images";

        public List<Series> Series = new List<Series>();

        public List<NewSeries> ListOfNewSeries = new List<NewSeries>();

        public void Build()
        {
            Series = new List<Series>()
            {
                new Series
                {
                    Name = "Death Note",
                    CoverImageSource = $"{IMAGES}/posters/death-note.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2006, 10, 3),
                    Seasons = new List<int>() { 37 },
                    FSK = FSK.PEGI_12,
                    Rating = 9.0m,
                    Description = "Yagami Light is an ace student with great aspects who’s bored out of his mind. " +
                    "One day he finds the Death Note, a notebook held by a shinigami (Death God). " +
                    "With the Death Note in hand, Light decides to create a perfect world. A world without crime or criminals. " +
                    "However when criminals start dropping dead one by one, the authorities send the legendary detective L to track down the killer.",
                    LogoImageSource = $"{IMAGES}/logos/death-note.png",
                    BannerImageSource = $"{IMAGES}/banners/death-note.png",
                    Genres = new List<Genre>() { Genre.Mystery, Genre.Psycho },
                    ShotsSources = new List<string>(),
                    Characters = new List<Character>()
                },
                new Series
                {
                    Name = "Attack on Titan",
                    CoverImageSource = $"{IMAGES}/posters/attack-on-titan.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2013, 4, 7),
                    Seasons = new List<int>() { 25, 12, 22, 28 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.0m,
                    Description = "Humans are nearly exterminated by giant creatures called Titans. " +
                    "Titans are typically several stories tall, seem to have no intelligence, devour human beings and, worst of all, " +
                    "seem to do it for the pleasure rather than as a food source. A small percentage of humanity survived by walling themselves " +
                    "in a land protected by extremely high walls, even taller than the biggest of titans. Flash forward to the present, and mankind has " +
                    "not seen a titan in over 100 years. One day, 10 year old Eren and his foster sister Mikasa witness something horrific as the city " +
                    "walls are destroyed by a colossal titan that appears out of thin air. As the smaller titans flood the city, the two kids watch " +
                    "in horror as their mother is eaten alive. Eren vows that he will murder every single titan and take revenge for all of mankind.",
                    LogoImageSource = $"{IMAGES}/logos/attach-on-titan.png",
                    BannerImageSource = $"{IMAGES}/banners/attack-on-titan.png",
                    Genres = new List<Genre> { Genre.Shounen },
                    ShotsSources = new List<string>(),
                    Characters = new List<Character>()
                },
                new Series
                {
                    Name = "Bleach: Thousand Year Bloodwar",
                    CoverImageSource = $"{IMAGES}/posters/bleach-thousand-year-bloodwar.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2022, 10, 10),
                    Seasons = new List<int>() { 2 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.5m,
                    Description = "The peace is suddenly broken when warning sirens blare through the Soul Society. " +
                    "Residents, there are disappearing without a trace and nobody knows who's behind it. " +
                    "Meanwhile, a dark shadow is also extending itself toward Ichigo and his friends in Karakura Town.",
                    LogoImageSource = $"{IMAGES}/logos/bleach.png",
                    BannerImageSource = $"{IMAGES}/banners/bleach.png",
                    Genres = new List<Genre>() { Genre.Shounen },
                    ShotsSources = new List<string>(),
                    Characters = new List<Character>()
                }
            };
        }
    }
}
