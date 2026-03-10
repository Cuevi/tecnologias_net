using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Practico_Solucion_Empleados
{
    internal class NominaPrinter
    {
        public NominaPrinter() { }

        public void Imprimir(List<Empleado> empleados)
        {
            int cont = 1;
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Empleado nº{cont}: {empleado.Nombre}, salario: {empleado.CalcularSalario()}");
                cont++;
            }
        }
    }
}
