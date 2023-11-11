using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ToDoListApp
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public ObservableCollection<Tasks> Tareas { get; set; } = new ObservableCollection<Tasks>();

        public Tasks MiTarea { get; set; }= new Tasks();

        public MainPage()
        {
            InitializeComponent();
            CreateOneTask();
            BindingContext = this;
        }

        private void CreateOneTask()
        {
            var tarea = new Tasks()
            {
                TaskName = "Comprar Pan",
                Status = "Pendiente",
                ColorText = "Blue"

            };
            Tareas.Add(tarea);

        }
        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            Tareas.Add(MiTarea);
           
        }
    }
}