using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_FundamentosdeC_2DavidCuevas
{
    public class Usuario
    {
        private string nombre;
        private int edad;
        private double altura;
        private bool esEstudiante;
        public Usuario(string nombre, int edad, double altura, bool esEstudiente = false) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.esEstudiante = esEstudiente;
        }
    }
}
