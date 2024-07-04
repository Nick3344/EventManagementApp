using Microsoft.Maui.Controls;

namespace EventManagementApp
{
    public partial class EventDetailsPage : ContentPage
    {
        public EventDetailsPage()
        {
            InitializeComponent();
        }

        public EventDetailsPage(ViewModels.MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
