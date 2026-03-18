using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Models
{
    internal class Curso
    {
        public string nombre { get; set; }
        public int duracionHoras { get; set; }
        public Curso(string nombre, int duracionHoras)
        {
            this.nombre = nombre;
            this.duracionHoras = duracionHoras;
        }
    }
}
