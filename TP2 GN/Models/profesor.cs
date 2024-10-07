using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_GN.Models
{
    public class Profesor
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Domicilio { get; set; }
        private string Localidad { get; set; }
        private string Provicia { get; set; }
        private string NroCelular { get; set; }
        private string Categoria { get; set; }
        private string Posicion { get; set; }
        private string Materia { get; set; }
        private int CantidadHoras { get; set; }
        private decimal ValorHoraCatedra { get; set; }
        private string DiasClase { get; set; }
        private string NivelEnsenanza { get; set; }
        private string Horario { get; set; }
    }
}