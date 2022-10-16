using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anime_Dashboard.Model
{
    public class NewSeries : BaseSeries
    {
        public NewSeries(string name, string coverImageSource, List<int> seasons, int fSK, decimal rating) : base(name, coverImageSource, seasons, fSK, rating)
        {
        }
    }
}
