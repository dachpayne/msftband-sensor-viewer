using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class AltimeterPage : Page
    {
        public AltimeterViewModel ViewModel { get; } = new AltimeterViewModel();

        public AltimeterPage()
        {
            InitializeComponent();
        }
    }
}
