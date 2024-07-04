using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace EventManagementApp
{
    public partial class MainPage : ContentPage
    {
        private ViewModels.MainPageViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModels.MainPageViewModel();
            BindingContext = _viewModel;
            Debug.WriteLine("MainPage initialized");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.Navigation = Navigation;
        }
    }
}
