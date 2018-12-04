using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class HeartRatePage : Page
    {
        public HeartRateViewModel ViewModel { get; } = new HeartRateViewModel();

        public HeartRatePage()
        {
            InitializeComponent();
        }
    }
}
