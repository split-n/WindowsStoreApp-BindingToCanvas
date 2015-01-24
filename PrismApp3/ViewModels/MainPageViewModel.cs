using System.Collections.ObjectModel;
using Windows.Foundation;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp3.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        private ObservableCollection<Point> _points;

        public ObservableCollection<Point> Points
        {
            get { return _points; }
            private set { SetProperty(ref _points, value); }
        }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Points = new ObservableCollection<Point> {
                new Point(100, 10),
                new Point(50, 100),
                new Point(350, 220),
                new Point(120, 500)
            };
        }
    }
}
