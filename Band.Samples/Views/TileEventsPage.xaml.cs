using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class TileEventsPage : Page
    {
        public TileEventsViewModel ViewModel { get; } = new TileEventsViewModel();

        public TileEventsPage()
        {
            InitializeComponent();
        }
    }
}
