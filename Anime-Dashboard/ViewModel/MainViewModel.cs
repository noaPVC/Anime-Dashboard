using Anime_Dashboard.Core;
using Anime_Dashboard.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anime_Dashboard.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<BaseMedia> Items { get; set; }

        public MainViewModel()
        {
            DataService dataService = new DataService();
            dataService.Build();

            Items = new ObservableCollection<BaseMedia>(dataService.Media);
        }
    }
}
