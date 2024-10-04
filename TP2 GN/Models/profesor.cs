using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_GN.Models
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Domicilio { get; set; }
        public string Localidad { get; set; }
        public string Provicia { get; set; }
        public string NroCelular { get; set; }
        public string Categoria { get; set; }
        public string Posicion { get; set; }
        public string Materia { get; set; }
        public int CantidadHoras { get; set; }
        public decimal ValorHoraCatedra { get; set; }
        public string DiasClase { get; set; }
        public string NivelEnsenanza { get; set; }
        public string Horario { get; set; }
    }
}