using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico_Solucion_Empleados
{
    internal class EmpleadoFijo : Empleado
    {
        private decimal numero;
        private decimal salario;
        public EmpleadoFijo(string nombre, decimal numero, decimal salario) : base(nombre)
        {
            nombre = Nombre;
            this.numero = numero;
            this.salario = salario;
        }

        public override decimal CalcularSalario()
        {
            return numero * salario;
        }
    }
}
