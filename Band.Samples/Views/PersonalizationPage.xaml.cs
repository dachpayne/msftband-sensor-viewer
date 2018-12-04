using System;

using Band.Samples.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Band.Samples.Views
{
    public sealed partial class PersonalizationPage : Page
    {
        public PersonalizationViewModel ViewModel { get; } = new PersonalizationViewModel();

        public PersonalizationPage()
        {
            InitializeComponent();
        }
    }
}
