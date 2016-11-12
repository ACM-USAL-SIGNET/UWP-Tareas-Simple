using System.Collections.ObjectModel;

namespace Tareas
{
    public class ViewModel
    {

        // Sintaxis tipica de C#
        // public ObservableCollection<Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>();

        public ObservableCollection<Tarea> Tareas { get; set; }

        public ViewModel()
        {
            Tareas = new ObservableCollection<Tarea>();
        }
    }
}