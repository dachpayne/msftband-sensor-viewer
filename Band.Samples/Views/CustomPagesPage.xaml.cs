using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class CustomPagesPage : Page
    {
        public CustomPagesViewModel ViewModel { get; } = new CustomPagesViewModel();

        public CustomPagesPage()
        {
            InitializeComponent();
        }
    }
}
