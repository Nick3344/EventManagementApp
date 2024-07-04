using Microsoft.Maui.Controls;
using System.Diagnostics;

namespace EventManagementApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            AppDomain.CurrentDomain.UnhandledException += OnUnhandledException;
            TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Debug.WriteLine($"Unhandled exception: {e.ExceptionObject}");
        }

        private void OnUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Debug.WriteLine($"Unobserved task exception: {e.Exception}");
            e.SetObserved();
        }
    }
}
