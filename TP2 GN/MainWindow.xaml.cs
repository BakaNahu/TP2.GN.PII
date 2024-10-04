using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP2_GN.ViewModels;
using TP2_GN.Models;

namespace TP2_GN
{
    public partial class MainWindow : Window
    {
        private ProfesorViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            CargarProvincias();
            _viewModel = new ProfesorViewModel();
            DataContext = _viewModel;
        }
        
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.AgregarProfesor();
            MessageBox.Show("Profesor guardado correctamente.");
        }
        private void CargarProvincias()
        {
            List<string> provincias = new List<string>
            {
                "Buenos Aires",
                "Catamarca",
                "Chaco",
                "Chubut",
                "Córdoba",
                "Corrientes",
                "Entre Ríos",
                "Formoza",
                "Jujuy",
                "La Pampa",
                "La Rioja",
                "Mendoza",
                "Misiones",
                "Neuquen",
                "Rio Negro",
                "Salta",
                "San Juan",
                "San Luis",
                "Santa Cruz",
                "Santa Fe",
                "Santiago Del Estero",
                "Tierra Del Fuego",
                "Tucumán",
            };

            cbxProvincia.ItemsSource = provincias;

        }
    }
}
