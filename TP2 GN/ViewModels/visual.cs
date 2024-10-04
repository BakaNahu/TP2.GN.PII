using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2_GN.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TP2_GN.ViewModels
{
    public class ProfesorViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Profesor> Profesores { get; set; }
        public Profesor NuevoProfesor { get; set; }

        public ProfesorViewModel()
        {
            Profesores = new ObservableCollection<Profesor>();
            NuevoProfesor = new Profesor();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AgregarProfesor()
        {
            Profesores.Add(NuevoProfesor);
            NuevoProfesor = new Profesor();
            OnPropertyChanged(nameof(NuevoProfesor));
        }
    }
}
