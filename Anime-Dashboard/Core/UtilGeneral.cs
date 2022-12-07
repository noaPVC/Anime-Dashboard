using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.Core
{
    public static class UtilGeneral
    {
        public static string FormatLength(int length)
        {
            int hours = length / 60;
            int minutes = length % 60;

            if(length < 60) return $"{minutes}m";

            if (minutes != 0) return $"{hours}h {minutes}m";

            return $"{hours}h";
        }
    }
}
