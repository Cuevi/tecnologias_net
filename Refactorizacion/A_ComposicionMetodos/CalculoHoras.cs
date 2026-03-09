using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_ComposicionMetodos
{
    internal class CalculoHoras
    {
        public static double CalcularTotal(int horas, double tarifa)
        {
            return horas * tarifa;
        }

        public static void MostrarResumen(string nombre, double total)
        {
            Console.WriteLine("El nombre: "+ nombre + ", El total:" + total);
        }
    }
}
