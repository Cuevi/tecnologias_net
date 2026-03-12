using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2_FundamentosdeC_2DavidCuevas
{
    public class Persona
    {
        public string nombre { get; set; }
        private int edad { get; set; }
        private string ciudad { get; set; }
        private double salarioMensual { get; set; }
        private DateTime nacimiento { get; set; }

        public Persona(string nombre, int edad, string ciudad, double salarioMensual, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
            this.salarioMensual = salarioMensual;
            this.nacimiento = nacimiento;
        }
    }
}
