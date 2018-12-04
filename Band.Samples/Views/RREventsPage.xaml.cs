using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class RREventsPage : Page
    {
        public RREventsViewModel ViewModel { get; } = new RREventsViewModel();

        public RREventsPage()
        {
            InitializeComponent();
        }
    }
}
