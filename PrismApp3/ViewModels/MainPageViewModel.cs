using System;
using System.Collections.ObjectModel;
using Windows.Foundation;
using Microsoft.Practices.Prism.StoreApps;
using Microsoft.Practices.Prism.StoreApps.Interfaces;

namespace PrismApp3.ViewModels
{
    public class MainPageViewModel : ViewModel
    {
        private INavigationService _navigationService;

        private ObservableCollection<PointViewModel> _points;

        public ObservableCollection<PointViewModel> Points
        {
            get { return _points; }
            private set { SetProperty(ref _points, value); }
        }

        private string _imageUri;
        public string ImageUri
        {
            get { return _imageUri; }
            private set { SetProperty(ref _imageUri, value); }
        }



        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            Points = new ObservableCollection<PointViewModel> {
                new PointViewModel(0, 0),
                new PointViewModel(100, 50),
                new PointViewModel(400, 800),
                new PointViewModel(500, 1000),
                new PointViewModel(1000, 500),
                new PointViewModel(100, 1300)
            };
            ImageUri = "ms-appx:///2000x2000.png";
        }

        public class PointViewModel
        {
            public int Top { get; private set; }

            public int Left { get; private set; }

            public PointViewModel(int top, int left)
            {
                Top = top;
                Left = left;
            }
        }
    }
}
