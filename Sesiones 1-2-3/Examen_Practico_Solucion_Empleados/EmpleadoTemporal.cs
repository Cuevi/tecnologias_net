using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico_Solucion_Empleados
{
    internal class EmpleadoTemporal : Empleado
    {
        private int horas;
        private decimal salario;
        public EmpleadoTemporal(string nombre, int horas, decimal salario) : base(nombre)
        { 
            nombre = Nombre;
            this.horas = horas;
            this.salario = salario;
        }
        public override decimal CalcularSalario()
        {
            return salario * horas;
        }
    }
}
