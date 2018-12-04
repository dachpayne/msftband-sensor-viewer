using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Band.Samples.Views
{
    public sealed partial class AmbientLightPage : Page
    {
        public AmbientLightViewModel ViewModel { get; } = new AmbientLightViewModel();

        public AmbientLightPage()
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
