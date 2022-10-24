using Anime_Dashboard.Core;
using Anime_Dashboard.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            DataService dataService = new DataService();
            dataService.Build();
        }
    }
}
