using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace SchedulerSample
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            var specialTimeRegion = new ObservableCollection<SchedulerTimeRegion>();

            SchedulerTimeRegion timeRegion = new SchedulerTimeRegion()
            {
                StartTime = DateTime.Today.Date.AddHours(13),
                EndTime = DateTime.Today.Date.AddHours(14),
                Text = "Lunch",
                EnablePointerInteraction = false,
                ResourceIds = new ObservableCollection<object>() { "1", "2", "3" }
            };
            specialTimeRegion.Add(timeRegion);

            scheduler.TimelineView.TimeRegions = specialTimeRegion;
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public Brush BackgroundColor { get; set; }
        public Brush ForegroundColor { get; set; }
    }

    public class Model
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Brush Background { get; set; }
        public ObservableCollection<object> ResourceIds { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Model> CustomEvents { get; set; }
        public ObservableCollection<Employee> CustomResources { get; set; }

        public ViewModel()
        {
            GeneratingAppointments();
            GeneratingResources();
        }

        internal void GeneratingAppointments()
        {
            CustomEvents = new ObservableCollection<Model>()
            {
                new Model()
                {
                    EventName = "Project Meeting",
                    From = DateTime.Now,
                    To = DateTime.Today.AddHours(20),
                    Background = Colors.Green,
                    ResourceIds = new ObservableCollection<object>(){"1", "2", "3"}
                },

                new Model()
                {
                    EventName = "Auditing",
                    From = DateTime.Now,
                    To = DateTime.Today.AddHours(20),
                    Background = Colors.Violet,
                    ResourceIds = new ObservableCollection<object>(){"1", "2",}

                }
            };
        }

        private void GeneratingResources()
        {
            CustomResources = new ObservableCollection<Employee>()
            {
                new Employee(){Name="Stephen",Id="1",BackgroundColor = new SolidColorBrush(Color.FromArgb("#375E97")), ForegroundColor = Colors.White },
                new Employee(){Name="Zoey",Id="2",BackgroundColor = new SolidColorBrush(Color.FromArgb("#FB6542")), ForegroundColor = Colors.White },
                new Employee(){Name="Emilia",Id="3",BackgroundColor = new SolidColorBrush(Color.FromArgb("#FFBB00")), ForegroundColor = Colors.Black }
            };
        }
    }
}
