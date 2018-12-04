using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class NotificationsPage : Page
    {
        public NotificationsViewModel ViewModel { get; } = new NotificationsViewModel();

        public NotificationsPage()
        {
            InitializeComponent();
        }
    }
}
