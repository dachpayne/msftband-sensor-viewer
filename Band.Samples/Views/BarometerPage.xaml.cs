using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class BarometerPage : Page
    {
        public BarometerViewModel ViewModel { get; } = new BarometerViewModel();

        public BarometerPage()
        {
            InitializeComponent();
        }
    }
}
