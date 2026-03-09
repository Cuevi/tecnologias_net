using A_ComposicionMetodos;
using System;

namespace RefactorA
{
    class Program
    {
        // Main para pruebas
        static void Main(string[] args)
        {
            string nombre = "Ana";
            int horas = 42;
            double tarifa = 15;

            // Con composición de métodos: más legible, más testeable
            double total = CalculoHoras.CalcularTotal(horas, tarifa);
            CalculoHoras.MostrarResumen(nombre, total);

            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }

       
    }
}
