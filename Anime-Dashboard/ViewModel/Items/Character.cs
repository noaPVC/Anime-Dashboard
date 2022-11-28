using Anime_Dashboard.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.ViewModel
{
    public class Character : ViewModelBase
    {
        public string Name { get; set; }

        public string VoiceActorName { get; set; }

        public string ImageSource { get; set; }

        public Character(string name, string voiceActorName, string imageSource)
        {
            Name = name;
            VoiceActorName = voiceActorName;
            ImageSource = imageSource;
        }

        public override bool Equals(object? obj)
        {
            return obj is Character character &&
                   Name == character.Name &&
                   VoiceActorName == character.VoiceActorName &&
                   ImageSource == character.ImageSource;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, ImageSource);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
