using Anime_Dashboard.Enums;
using Anime_Dashboard.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

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
                    Name = "Attack on Titan",
                    CoverImageSource = $"{IMAGES}/posters/attack-on-titan.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2013, 4, 7),
                    Seasons = new List<int>() { 25, 12, 22, 28 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.0m,
                    Completed = false,
                    Description = "Humans are nearly exterminated by giant creatures called Titans. " +
                    "Titans are typically several stories tall, seem to have no intelligence, devour human beings and, worst of all, " +
                    "seem to do it for the pleasure rather than as a food source. A small percentage of humanity survived by walling themselves " +
                    "in a land protected by extremely high walls, even taller than the biggest of titans. Flash forward to the present, and mankind has " +
                    "not seen a titan in over 100 years. One day, 10 year old Eren and his foster sister Mikasa witness something horrific as the city " +
                    "walls are destroyed by a colossal titan that appears out of thin air. As the smaller titans flood the city, the two kids watch " +
                    "in horror as their mother is eaten alive. Eren vows that he will murder every single titan and take revenge for all of mankind.",
                    LogoImageSource = $"{IMAGES}/logos/attach-on-titan.png",
                    BannerImageSource = $"{IMAGES}/banners/attack-on-titan.png",
                    Genres = new ObservableCollection<Genre> { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/1.png", "The Other Side of the Sea", 1, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/2.png", "Midnight Train", 2, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/3.png", "The Door of Hope", 3, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/4.png", "From One Hand to Another", 4, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/5.png", "Declaration of War", 5, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/6.png", "The Warhammer Titan", 6, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/7.png", "Assault", 7, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/8.png", "Assassin's Bullet", 8, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/9.png", "Brave Volunteers", 9, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/10.png", "A Sound Argument", 10, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/11.png", "Deceiver", 11, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/12.png", "Guides", 12, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/13.png", "Children of the Forest", 13, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/14.png", "Savagery", 14, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/15.png", "Sole Salvation", 15, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/16.png", "Above and Below", 16, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/17.png", "Judgement", 17, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/18.png", "Sneak Attack", 18, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/19.png", "Two Brothers", 19, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/20.png", "Memories of the Future", 20, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/21.png", "From you, 2000 Years ago", 21, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/22.png", "Thaw", 22, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/23.png", "Sunset", 23, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/24.png", "Pride", 24, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/25.png", "Night of the End", 25, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/26.png", "Traitor", 26, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/27.png", "Retrospective", 27, 4, 23),
                        new EpisodeShot($"{IMAGES}/shots/attack-on-titan/28.png", "The Dawn of Humanity", 28, 4, 23),
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Eren Yeager", "Yuki Kaji", $"{IMAGES}/characters/attack-on-titan/eren.png"),
                        new Character("Mikasa Ackermann", "Yui Ishikawa", $"{IMAGES}/characters/attack-on-titan/mikasa.png"),
                        new Character("Armin Arlert", "Marina Inoue", $"{IMAGES}/characters/attack-on-titan/armin.png"),
                        new Character("Levi Ackermann", "Hiroshi Kamiya", $"{IMAGES}/characters/attack-on-titan/levi.png"),
                        new Character("Grisha Yeager", "Hiroshi Tsuchida", $"{IMAGES}/characters/attack-on-titan/grisha.png"),
                        new Character("Annie Leonhart", "Yū Shimamura", $"{IMAGES}/characters/attack-on-titan/annie.png"),
                        new Character("Hanji Zoe", "Romi Park", $"{IMAGES}/characters/attack-on-titan/hanji.png"),
                        new Character("Yelena", "Anairis Quinones", $"{IMAGES}/characters/attack-on-titan/yelena.png"),
                        new Character("Reiner Braun", "Yoshimasa Hosoya", $"{IMAGES}/characters/attack-on-titan/reiner.png"),
                        new Character("Zeke Yeager", "Takehito Koyasu", $"{IMAGES}/characters/attack-on-titan/zeke.png")
                    }
                },
                new Series
                {
                    Name = "Chainsaw Man",
                    CoverImageSource = $"{IMAGES}/posters/chainsaw-man.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2022, 10, 12),
                    Seasons = new List<int>() { 7 },
                    FSK = FSK.PEGI_16,
                    Rating = 8.8m,
                    Completed = false,
                    Description = "Denji is a teenage boy living with a Chainsaw Devil named Pochita. " +
                    "Due to the debt his father left behind, he has been living a rock-bottom life while " +
                    "repaying his debt by harvesting devil corpses with Pochita. " +
                    "One day, Denji is betrayed and killed. As his consciousness fades, " +
                    "he makes a contract with Pochita and gets revived as Chainsaw Man — a man with a devil's heart.",
                    LogoImageSource = $"{IMAGES}/logos/chainsaw-man.png",
                    BannerImageSource = $"{IMAGES}/banners/chainsaw-man.png",
                    Genres = new ObservableCollection<Genre> { Genre.Shounen, Genre.Psycho },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/1.png", "Dog and Chainsaw", 1, 1, 25),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/2.png", "Arrival in Tokyo", 2, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/3.png", "Meowy's Whereabouts", 3, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/4.png", "Rescue", 4, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/5.png", "Gun Devil", 5, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/6.png", "Kill Denji", 6, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/chainsaw-man/7.png", "The Taste of a Kiss", 7, 1, 23),
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Denji", "Kikunosuke Toya", $"{IMAGES}/characters/chainsaw-man/denji.png"),
                        new Character("Aki", "Shogo Sakata", $"{IMAGES}/characters/chainsaw-man/aki.png"),
                        new Character("Makima", "Suzie Yeung", $"{IMAGES}/characters/chainsaw-man/makima.png"),
                        new Character("Himeno", "Katelyn Barr", $"{IMAGES}/characters/chainsaw-man/himeno.png"),
                        new Character("Pochita", "Shiori Izawa", $"{IMAGES}/characters/chainsaw-man/pochita.png"),
                        new Character("Power", "Fairouz Ai", $"{IMAGES}/characters/chainsaw-man/power.png"),
                        new Character("Kishibe", "Kenjiro Tsuda", $"{IMAGES}/characters/chainsaw-man/kishibe.png")
                    }
                },
                new Series
                {
                    Name = "Death Note",
                    CoverImageSource = $"{IMAGES}/posters/death-note.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2006, 10, 3),
                    Seasons = new List<int>() { 37 },
                    FSK = FSK.PEGI_12,
                    Rating = 9.0m,
                    Completed = true,
                    Description = "Yagami Light is an ace student with great aspects who’s bored out of his mind. " +
                    "One day he finds the Death Note, a notebook held by a shinigami (Death God). " +
                    "With the Death Note in hand, Light decides to create a perfect world. A world without crime or criminals. " +
                    "However when criminals start dropping dead one by one, the authorities send the legendary detective L to track down the killer.",
                    LogoImageSource = $"{IMAGES}/logos/death-note.png",
                    BannerImageSource = $"{IMAGES}/banners/death-note.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Mystery, Genre.Psycho },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/death-note/1.png", "", 1, 1, 25)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Light", "", $"{IMAGES}/characters/death-note/light.png"),
                        new Character("L. Lawliet", "", $"{IMAGES}/characters/death-note/light.png")
                    }
                },
                new Series
                {
                    Name = "Demon Slayer - Mugen Train Arc",
                    CoverImageSource = $"{IMAGES}/posters/demon-slayer-mugen-train.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2020, 10, 16),
                    Seasons = new List<int>() { 37 },
                    FSK = FSK.PEGI_16,
                    Rating = 8.2m,
                    Completed = true,
                    Description = "Flame Hashira Kyojuro Rengoku receives new orders: Travel to the Mugen Train, where over forty people have gone missing, " +
                    "and conduct an investigation. Leaving the Demon Slayer Corps Headquarters, he sets off on this new mission.",
                    LogoImageSource = $"{IMAGES}/logos/demon-slayer-mugen-train.png",
                    BannerImageSource = $"{IMAGES}/banners/demon-slayer-mugen-train.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Mystery, Genre.Psycho },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "Bleach: Thousand Year Bloodwar",
                    CoverImageSource = $"{IMAGES}/posters/bleach-thousand-year-bloodwar.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2022, 10, 10),
                    Seasons = new List<int>() { 22, 22, 16, 22, 16, 7, 17, 36, 57, 26, 18, 4 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.5m,
                    Completed = false,
                    Description = "The peace is suddenly broken when warning sirens blare through the Soul Society. " +
                    "Residents, there are disappearing without a trace and nobody knows who's behind it. " +
                    "Meanwhile, a dark shadow is also extending itself toward Ichigo and his friends in Karakura Town.",
                    LogoImageSource = $"{IMAGES}/logos/bleach.png",
                    BannerImageSource = $"{IMAGES}/banners/bleach.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "Jujutsu Kaisen 0",
                    CoverImageSource = $"{IMAGES}/posters/jujutsu-kaisen-0.png",
                    MediumType = MediumType.Movie,
                    ReleaseDate = new DateTime(2022, 12, 24),
                    Seasons = new List<int>(),
                    FSK = FSK.PEGI_16,
                    Rating = 7.8m,
                    Completed = true,
                    Description = "Yuuta Okkotsu is haunted. Ever since his childhood friend Rika died in a traffic accident, her ghost has stuck with him. " +
                    "But her spirit does not appear as the sweet girl Yuuta once knew. Instead, she manifests as a monstrous and powerful entity who fiercely protects him. " +
                    "Unable to control Rika's violent behavior, Yuuta is helpless to stop the bloodshed that follows from her brutal vengeance. As a result, " +
                    "when apprehended by jujutsu sorcerers, the secret guardians of the world, trained to combat forces like Rika. Yuuta wishes to be completely isolated " +
                    "so that no one else can get hurt. Yet his apprehender, the master sorcerer Satoru Gojou, has different plans for him: he will join Jujutsu High " +
                    "School and learn to control Rika in order to help people. Now a first-year at this school, Yuuta starts to learn Jujutsu arts and combat malignant " +
                    "beings. Alongside his new classmates Maki Zenin, a Jujutsu weapons expert; Toge Inumaki, a spellcaster who uses his words as weapons; and Panda, a " +
                    "seemingly walking and talking panda bear, Yuuta begins to find his place in the world and, for once, to feel comfortable with his abilities. " +
                    "However, as his training progresses, Yuuta comes to learn that the dangers of the Jujutsu world go far beyond that of wicked spirits.",
                    LogoImageSource = $"{IMAGES}/logos/jujutsu-kaisen-0.png",
                    BannerImageSource = $"{IMAGES}/banners/jujutsu-kaisen-0.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Mystery, Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "My Dressup Darling",
                    CoverImageSource = $"{IMAGES}/posters/my-dressup-darling.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2022, 1, 1),
                    Seasons = new List<int>() { 12 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.1m,
                    Completed = false,
                    Description = "High schooler Wakana Gojou cares about one thing: making Hina dolls. With nobody to share his obsession, " +
                    "he has trouble finding friends or even holding conversation. But after the school's most popular girl, Marin Kitagawa, reveals a secret of her own, " +
                    "he discovers a new purpose for his sewing skills. Together, they'll make her cosplay dreams come true.",
                    LogoImageSource = $"{IMAGES}/logos/my-dressup-darling.png",
                    BannerImageSource = $"{IMAGES}/banners/my-dressup-darling.png",
                    Genres = new ObservableCollection<Genre>() { Genre.SliceOfLife, Genre.Ecchi },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "Naruto Shippuden",
                    CoverImageSource = $"{IMAGES}/posters/naruto-shippuden.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2007, 2, 15),
                    Seasons = new List<int>() { 32, 21, 18, 17, 24, 31, 8, 24, 21, 33, 20, 25, 28, 13, 11, 21, 20, 66, 21 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.7m,
                    Completed = true,
                    Description = "Naruto Uzumaki wants to be the best ninja in the land. He's done well so far, but with the looming danger posed by the " +
                    "mysterious Akatsuki organization, Naruto knows he must train harder than ever and leaves his village for intense exercises that will push him to " +
                    "his limits.",
                    LogoImageSource = $"{IMAGES}/logos/naruto-shippuden.png",
                    BannerImageSource = $"{IMAGES}/banners/naruto-shippuden.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "One Punch Man",
                    CoverImageSource = $"{IMAGES}/posters/one-punch-man.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2015, 10, 1),
                    Seasons = new List<int>() { 12, 12 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.7m,
                    Completed = false,
                    Description = "In a world of superhuman beings, Saitama is a unique hero, he can defeat enemies with a single punch. But being just one hero in a world " +
                    "filled with them, his life is empty and hollow: he gets no respect from anyone, he displays a laidback attitude to everything and for the most part, " +
                    "he finds his overall hero life pointless... and worst of all, he lost his hair due to intense training. These are the adventures of an ordinary " +
                    "yet extraordinary hero.",
                    LogoImageSource = $"{IMAGES}/logos/one-punch-man.png",
                    BannerImageSource = $"{IMAGES}/banners/one-punch-man.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },
                new Series
                {
                    Name = "SpyxFamily",
                    CoverImageSource = $"{IMAGES}/posters/spyxfamily.png",
                    MediumType = MediumType.Series,
                    ReleaseDate = new DateTime(2022, 4, 9),
                    Seasons = new List<int>() { 12, 8 },
                    FSK = FSK.Not_Rated,
                    Rating = 8.6m,
                    Completed = false,
                    Description = "A spy known only as Twilight needs a family as part of his undercover mission, so he quickly marries a city hall worker and adopts " +
                    "a child and dog. Unknown to him, his family has secrets of their own: his wife Yor is an undercover assassin, his daughter Anya is a " +
                    "runaway psychic who can read minds, and his dog was from a laboratory that gave him the power to tell the future. " +
                    "All these four subjects must bond together as a family to manage their own affairs and be together as best as they can.",
                    LogoImageSource = $"{IMAGES}/logos/spyxfamily.png",
                    BannerImageSource = $"{IMAGES}/banners/spyxfamily.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen, Genre.Mystery },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                },

                // eminence in shadow as well as monster is still missing
                // collect frames for death note, monster, and bleach
            };
        }
    }
}
