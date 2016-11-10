using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Tareas
{
    public class ViewModel
    {
        public ObservableCollection<Tarea> Tareas { get; set; } = new ObservableCollection<Tarea>(); 
    }
}