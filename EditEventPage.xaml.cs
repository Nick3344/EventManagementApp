using Microsoft.Maui.Controls;
using EventManagementApp.ViewModels;

namespace EventManagementApp
{
    public partial class EditEventPage : ContentPage
    {
        public EditEventPage(MainPageViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
