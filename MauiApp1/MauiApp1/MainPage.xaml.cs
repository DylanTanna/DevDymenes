using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public ObservableCollection<TaskItem> Tasks { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Tasks = new ObservableCollection<TaskItem>
            {
                new TaskItem { Titulo = "Estudar MAUI", Concluida = false },
                new TaskItem { Titulo = "Multiplas tasks", Concluida = true },
                new TaskItem { Titulo = "Commit", Concluida = false }
            };

             BindingContext = this;

        }
        
    }
}
