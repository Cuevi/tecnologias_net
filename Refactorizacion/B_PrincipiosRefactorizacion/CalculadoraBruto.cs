using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_PrincipiosRefactorizacion
{
    internal class CalculadoraBruto
    {
        internal static double CalcularBruto(int horas, double valor)
        {
            if (horas <= 0) { throw new Exception($"Horas negativas: {horas}"); }
            return horas * valor;
        }
    }
}
