using Anime_Dashboard.Enums;
using Anime_Dashboard.ViewModel;
using Anime_Dashboard.ViewModel.Items;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.Services
{
    public class DataService
    {
        const string IMAGES = "/Resources/Images";

        public List<BaseMedia> Media = new List<BaseMedia>();
        public List<NewSeries> ListOfNewSeries = new List<NewSeries>();

        public void Build()
        {
            Media = new List<BaseMedia>()
            {
                new Series
                {
                    Name = "Attack on Titan",
                    CoverImageSource = $"{IMAGES}/posters/attack-on-titan.png",
                    ReleaseDate = new DateTime(2013, 4, 7),
                    Seasons = new List<int>() { 25, 12, 22, 28 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.0m,
                    Completed = false,
                    IsSeries = true,
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
                    ReleaseDate = new DateTime(2022, 10, 12),
                    Seasons = new List<int>() { 7 },
                    FSK = FSK.PEGI_16,
                    Rating = 8.8m,
                    Completed = false,
                    IsSeries = true,
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
                    ReleaseDate = new DateTime(2006, 10, 3),
                    Seasons = new List<int>() { 37 },
                    FSK = FSK.PEGI_12,
                    Rating = 9.0m,
                    Completed = true,
                    IsSeries = true,
                    Description = "Yagami Light is an ace student with great aspects who’s bored out of his mind. " +
                    "One day he finds the Death Note, a notebook held by a shinigami (Death God). " +
                    "With the Death Note in hand, Light decides to create a perfect world. A world without crime or criminals. " +
                    "However when criminals start dropping dead one by one, the authorities send the legendary detective L to track down the killer.",
                    LogoImageSource = $"{IMAGES}/logos/death-note.png",
                    BannerImageSource = $"{IMAGES}/banners/death-note.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Mystery, Genre.Psycho },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/death-note/1.png", "Rebirth", 1, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/2.png", "Confrontation", 2, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/3.png", "Dealings", 3, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/4.png", "Pursuit", 4, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/5.png", "Tactics", 5, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/6.png", "Unraveling", 6, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/7.png", "Overcast", 7, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/8.png", "Glare", 8, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/9.png", "Encounter", 9, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/10.png", "Doubt", 10, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/11.png", "Assault", 11, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/12.png", "Love", 12, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/13.png", "Confession", 13, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/14.png", "Friend", 14, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/15.png", "Wager", 15, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/16.png", "Decision", 16, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/17.png", "Execution", 17, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/19.png", "Matsuda", 19, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/20.png", "Makeshift", 20, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/21.png", "Performance", 21, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/22.png", "Guidance", 22, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/23.png", "Frenzy", 23, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/24.png", "Revival", 24, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/25.png", "Silence", 25, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/26.png", "Renewal", 26, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/27.png", "Abduction", 27, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/28.png", "Impatience", 28, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/29.png", "Father", 29, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/30.png", "Justice", 30, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/31.png", "Transfer", 31, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/32.png", "Selection", 32, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/33.png", "Scorn", 33, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/34.png", "Vigilance", 34, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/35.png", "Malice", 35, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/36.png", "1.28", 36, 1, 22),
                        new EpisodeShot($"{IMAGES}/shots/death-note/37.png", "New World", 37, 1, 22)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Light Yagami", "Mamoru Miyano", $"{IMAGES}/characters/death-note/light.png"),
                        new Character("L. Lawliet", "Kappei Yamaguchi", $"{IMAGES}/characters/death-note/lawliet-l.png"),
                        new Character("Misa Amane", "Aya Hirano", $"{IMAGES}/characters/death-note/misa.png"),
                        new Character("Near", "Noriko Hidaka", $"{IMAGES}/characters/death-note/near.png"),
                        new Character("Mello", "Nozomu Sasaki", $"{IMAGES}/characters/death-note/mello.png"),
                        new Character("Rem", "Kimiko Saitō", $"{IMAGES}/characters/death-note/rem.png"),
                        new Character("Ryuk", "Nakamura Shidō", $"{IMAGES}/characters/death-note/ryuk.png"),
                        new Character("Soichiro Yagami", "Naoya Uchida", $"{IMAGES}/characters/death-note/soichiro.png"),
                        new Character("Watari", "Kiyoshi Kobayashi", $"{IMAGES}/characters/death-note/watari.png"),
                        new Character("Aizawa", "Keiji Fujiwara", $"{IMAGES}/characters/death-note/aizawa.png")
                    }
                },
                new Series
                {
                    Name = "Demon Slayer - Mugen Train Arc",
                    CoverImageSource = $"{IMAGES}/posters/demon-slayer-mugen-train.png",
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
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/1.png", "Flame Hashira Kyojuro Rengoku", 1, 2, 26),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/2.png", "Deep Sleep", 2, 2, 22),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/3.png", "Should Have Been", 3, 2, 25),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/4.png", "Insult", 4, 2, 23),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/5.png", "Move Forward", 5, 2, 21),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/6.png", "Akaza", 6, 2, 23),
                        new EpisodeShot($"{IMAGES}/shots/demon-slayer-mugen-train/7.png", "Set Your Heart Ablaze", 7, 2, 26),
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Tanjiro Kamado", "Natsuki Hanae", $"{IMAGES}/characters/demon-slayer-mugen-train/tanjiro.png"),
                        new Character("Inosuke Hashibira", "Yoshitsugu Matsuoka", $"{IMAGES}/characters/demon-slayer-mugen-train/inosuke.png"),
                        new Character("Nezuko Kamado", "Akari Kito", $"{IMAGES}/characters/demon-slayer-mugen-train/nezuko.png"),
                        new Character("Zenitsu Agatsuma", "Hiro Shimono", $"{IMAGES}/characters/demon-slayer-mugen-train/zenitsu.png"),
                        new Character("Rengoku Kyojuro", "Satoshi Hino", $"{IMAGES}/characters/demon-slayer-mugen-train/rengoku.png"),
                        new Character("Akaza", "Akira Ishida", $"{IMAGES}/characters/demon-slayer-mugen-train/akaza.png"),
                        new Character("Enmu", "Daisuke Hirakawa", $"{IMAGES}/characters/demon-slayer-mugen-train/enmu.png"),
                        new Character("Senjuro Kyojuro", "Junya Enoki", $"{IMAGES}/characters/demon-slayer-mugen-train/senjuro.png"),
                        new Character("Rokuta Kamado", "Aoi Koga", $"{IMAGES}/characters/demon-slayer-mugen-train/rokuta.png"),
                        new Character("Takeo Kamado", "Yo Taichi", $"{IMAGES}/characters/demon-slayer-mugen-train/takeo.png"),
                        new Character("Shigeru Kamado", "Kaede Hondo", $"{IMAGES}/characters/demon-slayer-mugen-train/shigeru.png"),
                        new Character("Hanako Kamado", "Konomi Kohara", $"{IMAGES}/characters/demon-slayer-mugen-train/hanako.png")
                    }
                },
                new Series
                {
                    Name = "Bleach: Thousand Year Bloodwar",
                    CoverImageSource = $"{IMAGES}/posters/bleach-thousand-year-bloodwar.png",
                    ReleaseDate = new DateTime(2022, 10, 10),
                    Seasons = new List<int>() { 22, 22, 16, 22, 16, 7, 17, 36, 57, 26, 18, 4 },
                    FSK = FSK.PEGI_16,
                    Rating = 9.5m,
                    Completed = false,
                    IsSeries = true,
                    Description = "The peace is suddenly broken when warning sirens blare through the Soul Society. " +
                    "Residents, there are disappearing without a trace and nobody knows who's behind it. " +
                    "Meanwhile, a dark shadow is also extending itself toward Ichigo and his friends in Karakura Town.",
                    LogoImageSource = $"{IMAGES}/logos/bleach.png",
                    BannerImageSource = $"{IMAGES}/banners/bleach.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>(),
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Aizen", "Yasushi Ōhama", $"{IMAGES}/characters/bleach/aizen.png"),
                        new Character("Ichigo", "Masakazu Morita", $"{IMAGES}/characters/bleach/ichigo.png"),
                        new Character("Kenpachi", "Fumihiko Tachiki", $"{IMAGES}/characters/bleach/kenpachi.png"),
                        new Character("Kisuke", "Shinichiro Miki", $"{IMAGES}/characters/bleach/kisuke.png"),
                        new Character("Orihime", "Yuki Matsuoka", $"{IMAGES}/characters/bleach/orihime.png"),
                        new Character("Rukia", "Fumiko Orikasa", $"{IMAGES}/characters/bleach/rukia.png"),
                        new Character("Shigekuni", "Masaaki Tsukada", $"{IMAGES}/characters/bleach/shigekuni.png"),
                        new Character("Uryu", "Noriaki Sugiyama", $"{IMAGES}/characters/bleach/uryu.png"),
                        new Character("Yhwach", "Takayuki Sugo", $"{IMAGES}/characters/bleach/yhwach.png"),
                        new Character("Yoruichi", "Satsuki Yukino", $"{IMAGES}/characters/bleach/yoruichi.png")
                    }
                },
                new Movie
                {
                    Name = "Jujutsu Kaisen 0",
                    CoverImageSource = $"{IMAGES}/posters/jujutsu-kaisen-0.png",
                    ReleaseDate = new DateTime(2022, 12, 24),
                    FSK = FSK.PEGI_16,
                    Rating = 7.8m,
                    IsSeries = false,
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
                    EmbedShot = new MovieShot($"{IMAGES}/shots/jujutsu-kaisen-0/1.png", 104),
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Satoru Gojo", "Yuichi Nakamura", $"{IMAGES}/characters/jujutsu-kaisen-0/satoru.png"),
                        new Character("Suguru Geto", "Takahiro Sakurai", $"{IMAGES}/characters/jujutsu-kaisen-0/suguru.png"),
                        new Character("Yuta Okkotsu", "Megumi Ogata", $"{IMAGES}/characters/jujutsu-kaisen-0/yuta.png"),
                        new Character("Toge Inumaki", "Kōki Uchiyama", $"{IMAGES}/characters/jujutsu-kaisen-0/toge.png"),
                        new Character("Rika Orimoto", "Kana Hanazawa", $"{IMAGES}/characters/jujutsu-kaisen-0/rika.png"),
                        new Character("Nanami Kento", "Kenjiro Tsuda", $"{IMAGES}/characters/jujutsu-kaisen-0/nanami.png"),
                        new Character("Maki Zenin", "Mikako Komatsu", $"{IMAGES}/characters/jujutsu-kaisen-0/maki.png"),
                        new Character("Panda", "Tomokazu Seki", $"{IMAGES}/characters/jujutsu-kaisen-0/panda.png"),
                        new Character("Aoi Todo", "Subaru Kimura", $"{IMAGES}/characters/jujutsu-kaisen-0/aoi.png"),
                        new Character("Meimei", "Kotono Mitsuishi", $"{IMAGES}/characters/jujutsu-kaisen-0/meimei.png")
                    }
                },
                new Series
                {
                    Name = "My Dressup Darling",
                    CoverImageSource = $"{IMAGES}/posters/my-dressup-darling.png",
                    ReleaseDate = new DateTime(2022, 1, 1),
                    Seasons = new List<int>() { 12 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.1m,
                    Completed = false,
                    IsSeries = true,
                    Description = "High schooler Wakana Gojou cares about one thing: making Hina dolls. With nobody to share his obsession, " +
                    "he has trouble finding friends or even holding conversation. But after the school's most popular girl, Marin Kitagawa, reveals a secret of her own, " +
                    "he discovers a new purpose for his sewing skills. Together, they'll make her cosplay dreams come true.",
                    LogoImageSource = $"{IMAGES}/logos/my-dressup-darling.png",
                    BannerImageSource = $"{IMAGES}/banners/my-dressup-darling.png",
                    Genres = new ObservableCollection<Genre>() { Genre.SliceOfLife, Genre.Ecchi },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/1.png", "Someone Who Lives in the Exact Opposite Worls as Me", 1, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/2.png", "Wanna Hurry Up, and Do It?", 2, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/3.png", "Then Why Don't We?", 3, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/4.png", "Are These Your Girlfriend's?", 4, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/5.png", "It's Probably Because this is the best Boob Bag Here", 5, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/6.png", "For Real?!", 6, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/7.png", "A Home Date with the Guy I Wuv Is the Best", 7, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/8.png", "Backlighting Is the Best", 8, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/9.png", "A Lot Happened After I Saw That Photo", 9, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/10.png", "We've All Got Struggles", 10, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/11.png", "I Am Currently at a Love Hotel", 11, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/my-dressup-darling/12.png", "My Dress-Up Darling", 12, 1, 23)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Gojo Wakana", "Shōya Ishige", $"{IMAGES}/characters/my-dressup-darling/gojo.png"),
                        new Character("Marin Kitagawa", "Hina Suguta", $"{IMAGES}/characters/my-dressup-darling/marin.png"),
                        new Character("Shinju Inui", "Hina Yomiya", $"{IMAGES}/characters/my-dressup-darling/shinju.png"),
                        new Character("Sajuna Inui", "Atsumi Tanezaki", $"{IMAGES}/characters/my-dressup-darling/sajuna.png"),
                        new Character("Sugaya", "Rarisa Tago Takeda", $"{IMAGES}/characters/my-dressup-darling/sugaya.png"),
                        new Character("Miori", "Misako Tomioka", $"{IMAGES}/characters/my-dressup-darling/miori.png"),
                        new Character("Akira", "Ayumu Murase", $"{IMAGES}/characters/my-dressup-darling/akira.png")
                    }
                },
                new Series
                {
                    Name = "Naruto Shippuden",
                    CoverImageSource = $"{IMAGES}/posters/naruto-shippuden.png",
                    ReleaseDate = new DateTime(2007, 2, 15),
                    Seasons = new List<int>() { 32, 21, 18, 17, 24, 31, 8, 24, 21, 33, 20, 25, 28, 13, 11, 21, 20, 66, 21 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.7m,
                    Completed = true,
                    IsSeries = true,
                    Description = "Naruto Uzumaki wants to be the best ninja in the land. He's done well so far, but with the looming danger posed by the " +
                    "mysterious Akatsuki organization, Naruto knows he must train harder than ever and leaves his village for intense exercises that will push him to " +
                    "his limits.",
                    LogoImageSource = $"{IMAGES}/logos/naruto-shippuden.png",
                    BannerImageSource = $"{IMAGES}/banners/naruto-shippuden.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/1.png", "Homecoming", 1, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/2.png", "The Akatsuki Makes Its Move", 2, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/3.png", "The Results of Training", 3, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/4.png", "The Jinchuriki of the Sand", 4, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/5.png", "The Kazekage Stands Taal", 5, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/6.png", "Mission Cleared", 6, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/7.png", "Run, Kankuro", 7, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/8.png", "Team Kakashi, Deployed", 8, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/9.png", "The Jinchuriki's Tears", 9, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/10.png", "Sealing Jutsu: Nine Phantom Dragons", 10, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/11.png", "The Medical Ninja's Student", 11, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/12.png", "The Retired Granny's Determination", 12, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/13.png", "A Meeting With Destiny", 13, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/14.png", "Naruto's Growth", 14, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/15.png", "The Secret Weapon is Called....", 15, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/16.png", "The Secret of Jinchuriki", 16, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/17.png", "The Death of Gaara!", 17, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/18.png", "Charge Tactic! Button Hook Entry!!", 18, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/19.png", "Traps Activate! Team Guy's Enemy", 19, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/20.png", "Hiroku vs. Two Kunoichi", 20, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/21.png", "Sasori's Real Face", 21, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/22.png", "Chiyo's Secret Skills", 22, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/23.png", "Father and Mother", 23, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/24.png", "The Third Kazekage", 24, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/25.png", "Three Minutes Between Life and Death", 25, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/26.png", "Puppet Fight: 10 vs. 100!", 26, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/27.png", "Impossible Dream", 27, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/28.png", "Beasts: Alive Again!", 28, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/29.png", "Kakashi Enlightened!", 29, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/30.png", "Aesthetics of an Instant", 30, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/31.png", "The Legacy", 31, 1, 23),
                        new EpisodeShot($"{IMAGES}/shots/naruto-shippuden/32.png", "Return of the Kazekage", 32, 1, 23)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Naruto", "Junko Takeuchi", $"{IMAGES}/characters/naruto-shippuden/naruto.png"),
                        new Character("Kakashi", "Kazuhiko Inoue", $"{IMAGES}/characters/naruto-shippuden/kakashi.png"),
                        new Character("Obito", "Wataru Takagi", $"{IMAGES}/characters/naruto-shippuden/obito.png"),
                        new Character("Jiraya", "Hōchū Ōtsuka", $"{IMAGES}/characters/naruto-shippuden/jiraya.png"),
                        new Character("Madara", "Naoya Uchida", $"{IMAGES}/characters/naruto-shippuden/madara.png"),
                        new Character("Kaguya", "Mami Koyama", $"{IMAGES}/characters/naruto-shippuden/kaguya.png"),
                        new Character("Sasuke", "Noriaki Sugiyama", $"{IMAGES}/characters/naruto-shippuden/sasuke.png"),
                        new Character("Tsunade", "Masako Katsuki", $"{IMAGES}/characters/naruto-shippuden/tsunade.png"),
                        new Character("Itachi", "Hideo Ishikawa", $"{IMAGES}/characters/naruto-shippuden/itachi.png"),
                        new Character("Hinata", "Nana Mizuki", $"{IMAGES}/characters/naruto-shippuden/hinata.png")
                    }
                },
                new Series
                {
                    Name = "One Punch Man",
                    CoverImageSource = $"{IMAGES}/posters/one-punch-man.png",
                    ReleaseDate = new DateTime(2015, 10, 1),
                    Seasons = new List<int>() { 12, 12 },
                    FSK = FSK.PEGI_12,
                    Rating = 8.7m,
                    Completed = false,
                    IsSeries = true,
                    Description = "In a world of superhuman beings, Saitama is a unique hero, he can defeat enemies with a single punch. But being just one hero in a world " +
                    "filled with them, his life is empty and hollow: he gets no respect from anyone, he displays a laidback attitude to everything and for the most part, " +
                    "he finds his overall hero life pointless... and worst of all, he lost his hair due to intense training. These are the adventures of an ordinary " +
                    "yet extraordinary hero.",
                    LogoImageSource = $"{IMAGES}/logos/one-punch-man.png",
                    BannerImageSource = $"{IMAGES}/banners/one-punch-man.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/1.png", "The Strongest Man", 1, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/2.png", "The Lone Cyborg", 2, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/3.png", "The Obsessive Scientist", 3, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/4.png", "The Modern Ninja", 4, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/5.png", "The Ultimate Master", 5, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/6.png", "The Terrifying City", 6, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/7.png", "The Ultimate Discipline", 7, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/8.png", "The Deep Sea King", 8, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/9.png", "Unyielding Justice", 9, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/10.png", "Unparalleled Peril", 10, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/11.png", "The Dominator of the Universe", 11, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/one-punch-man/12.png", "The Strongest Hero", 12, 1, 24)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Saitama", "Makoto Furukawa", $"{IMAGES}/characters/one-punch-man/saitama.png"),
                        new Character("Genos", "Kaito Ishikawa", $"{IMAGES}/characters/one-punch-man/genos.png"),
                        new Character("Mumen Rider", "Yuichi Nakamura", $"{IMAGES}/characters/one-punch-man/biker.png"),
                        new Character("Garou", "Hikaru Midorikawa", $"{IMAGES}/characters/one-punch-man/garou.png"),
                        new Character("Fubuki", "Saori Hayami", $"{IMAGES}/characters/one-punch-man/fubuki.png"),
                        new Character("Tatsumaki", "Aoi Yuuki", $"{IMAGES}/characters/one-punch-man/tatsumaki.png"),
                        new Character("Sugar Mask", "Mamoru Miyano", $"{IMAGES}/characters/one-punch-man/sugar_mask.png"),
                        new Character("Speed o' Sound Sonic", "Yūki Kaji", $"{IMAGES}/characters/one-punch-man/sonic.png"),
                        new Character("King", "Hiroki Yasumoto", $"{IMAGES}/characters/one-punch-man/king.png"),
                        new Character("Bang", "Kazuhiro Yamaji", $"{IMAGES}/characters/one-punch-man/bang.png")
                    }
                },
                new Series
                {
                    Name = "SpyxFamily",
                    CoverImageSource = $"{IMAGES}/posters/spyxfamily.png",
                    ReleaseDate = new DateTime(2022, 4, 9),
                    Seasons = new List<int>() { 12, 8 },
                    FSK = FSK.Not_Rated,
                    Rating = 8.6m,
                    Completed = false,
                    IsSeries = true,
                    Description = "A spy known only as Twilight needs a family as part of his undercover mission, so he quickly marries a city hall worker and adopts " +
                    "a child and dog. Unknown to him, his family has secrets of their own: his wife Yor is an undercover assassin, his daughter Anya is a " +
                    "runaway psychic who can read minds, and his dog was from a laboratory that gave him the power to tell the future. " +
                    "All these four subjects must bond together as a family to manage their own affairs and be together as best as they can.",
                    LogoImageSource = $"{IMAGES}/logos/spyxfamily.png",
                    BannerImageSource = $"{IMAGES}/banners/spyxfamily.png",
                    Genres = new ObservableCollection<Genre>() { Genre.Shounen, Genre.Mystery },
                    Shots = new ObservableCollection<EpisodeShot>()
                    {
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/1.png", "Operation Strix", 1, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/2.png", "Secure a Wife", 2, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/3.png", "Prepare for the Interview", 3, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/4.png", "The Prestigious School's Interview", 4, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/5.png", "Will they Pass or Fail?", 5, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/6.png", "The Friendship Scheme", 6, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/7.png", "The Target's Second Son", 7, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/8.png", "The Counter Secret Police Cover Operation", 8, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/9.png", "Show Off How in Love You Are", 9, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/10.png", "The Great Dodgeball Plan", 10, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/11.png", "Stella", 11, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/12.png", "Penguin Park", 12, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/13.png", "Project Apple", 13, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/14.png", "Disarm the Time Bomb", 14, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/15.png", "A New Family Member", 15, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/16.png", "Yor's Kitchen/The Informant's Great Romance Plan", 16, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/17.png", "Carry out the Griffin Plan/Fullmetal Lady/Omelet Rice❤", 17, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/18.png", "Uncle the Private Tutor/Daybreak", 18, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/19.png", "A Revenge Plot Against Desmond/Mama Becomes the Wind", 19, 1, 24),
                        new EpisodeShot($"{IMAGES}/shots/spyxfamily/20.png", "Investigate the General Hospital/Decipher the Perplexing Code", 20, 1, 24)
                    },
                    Characters = new ObservableCollection<Character>()
                    {
                        new Character("Anya Forger", "Atsumi Tanezaki", $"{IMAGES}/characters/spyxfamily/anya.png"),
                        new Character("Loid Forger", "Takuya Eguchi", $"{IMAGES}/characters/spyxfamily/loid.png"),
                        new Character("Yor Forger", "Saori Hayami", $"{IMAGES}/characters/spyxfamily/yor.png"),
                        new Character("Yuri", "Kensho Ono", $"{IMAGES}/characters/spyxfamily/yuri.png"),
                        new Character("Damian", "Natsumi Fujiwara", $"{IMAGES}/characters/spyxfamily/damian.png"),
                        new Character("Franky", "Hiroyuki Yoshino", $"{IMAGES}/characters/spyxfamily/franky.png"),
                        new Character("Donovan", "Takaya Hashi", $"{IMAGES}/characters/spyxfamily/donovan.png"),
                        new Character("Henry", "Kazuhiro Yamaji", $"{IMAGES}/characters/spyxfamily/henry.png")
                    }
                }
                // eminence in shadow as well as monster is still missing
                // collect frames for death note, monster, and bleach
            };
        }
    }
}
