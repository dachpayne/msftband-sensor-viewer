using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Band.Samples.Views
{
    public sealed partial class AccelerometerPage : Page
    {
        public AccelerometerViewModel ViewModel { get; } = new AccelerometerViewModel();

        public AccelerometerPage()
        {
            InitializeComponent();
        }

        protected async override void OnNavigatedFrom(NavigationEventArgs e)
        {
            //
            base.OnNavigatedFrom(e);
        }

        private void Page_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.Initialize();
        }

        private void Page_Unloaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
