using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class GsrPage : Page
    {
        public GsrViewModel ViewModel { get; } = new GsrViewModel();

        public GsrPage()
        {
            InitializeComponent();
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
