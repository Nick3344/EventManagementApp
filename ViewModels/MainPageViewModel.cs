using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using EventManagementApp.Models;
using System.Diagnostics;

namespace EventManagementApp.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private ObservableCollection<Event> _events;
        private Event? _selectedEvent;
        private INavigation? _navigation;

        public MainPageViewModel()
        {
            Events = new ObservableCollection<Event>();
            AddEventCommand = new Command(OnAddEvent);
            ViewEventDetailsCommand = new Command<Event>(OnViewEventDetails);
            EditEventCommand = new Command<Event>(OnEditEvent);
            DeleteEventCommand = new Command<Event>(OnDeleteEvent);
            SaveEventCommand = new Command(OnSaveEvent);
            GoBackCommand = new Command(OnGoBack);
            Debug.WriteLine("MainPageViewModel initialized");
        }

        public ObservableCollection<Event> Events
        {
            get => _events;
            set
            {
                _events = value;
                OnPropertyChanged();
            }
        }

        public Event? SelectedEvent
        {
            get => _selectedEvent;
            set
            {
                _selectedEvent = value;
                OnPropertyChanged();
            }
        }

        public INavigation? Navigation
        {
            get => _navigation;
            set => _navigation = value;
        }

        public ICommand AddEventCommand { get; }
        public ICommand ViewEventDetailsCommand { get; }
        public ICommand EditEventCommand { get; }
        public ICommand DeleteEventCommand { get; }
        public ICommand SaveEventCommand { get; }
        public ICommand GoBackCommand { get; }

        private void OnAddEvent()
        {
            Debug.WriteLine("AddEventCommand executed");
            Events.Add(new Event { Name = "New Event", Location = "Location", Date = DateTime.Now });
        }

        private void OnViewEventDetails(Event selectedEvent)
        {
            Debug.WriteLine("ViewEventDetailsCommand executed");
            SelectedEvent = selectedEvent;
            _navigation?.PushAsync(new EventDetailsPage(this));
        }

        private void OnEditEvent(Event selectedEvent)
        {
            Debug.WriteLine("EditEventCommand executed");
            SelectedEvent = selectedEvent;
            _navigation?.PushAsync(new EditEventPage(this));
        }

        private void OnDeleteEvent(Event selectedEvent)
        {
            Debug.WriteLine("DeleteEventCommand executed");
            Events.Remove(selectedEvent);
        }

        private void OnSaveEvent()
        {
            Debug.WriteLine("SaveEventCommand executed");
            // We don't need to do anything specific since the event is already bound
            _navigation?.PopAsync();
        }

        private void OnGoBack()
        {
            _navigation?.PopAsync();
        }
    }
}
