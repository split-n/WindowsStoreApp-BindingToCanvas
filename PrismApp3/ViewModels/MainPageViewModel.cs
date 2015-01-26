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
                new PointViewModel(100, 10),
                new PointViewModel(50, 100),
                new PointViewModel(350, 220),
                new PointViewModel(120, 500)
            };
            ImageUri = "ms-appx:///2000x2000.png";
        }

        public class PointViewModel
        {
            public int Top { get; private set; }

            public int Left { get; private set; }

            public PointViewModel(int top,int left)
            {
                Top = top;
                Left = left;
            }
        }
    }
}
