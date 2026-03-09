using B_PrincipiosRefactorizacion;
using System;

namespace RefactorB
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bruto (80h, 12.5): " + CalculadoraBruto.CalcularBruto(80, 12.5));
                // Prueba de validación (descomenta para ver error controlado):
                 Console.WriteLine(CalculadoraBruto.CalcularBruto(-1, 10));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
