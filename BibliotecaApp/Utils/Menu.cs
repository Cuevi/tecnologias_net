using BibliotecaApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Utils
{
    public class Menu
    {
        public static void runMenu() {
            Console.Clear();
            Console.WriteLine("\n=== SISTEMA BIBLIOTECA ===");
            Console.WriteLine("1. Agregar libro");
            Console.WriteLine("2. Mostrar libros");
            Console.WriteLine("3. Registrar usuario");
            Console.WriteLine("4. Realizar préstamo");
            Console.WriteLine("0. Salir");
            chooseOption(Console.ReadLine() ?? "");
        }

        //TODO: Hacer el menu con un do while
        public static void chooseOption(string option)
        {
            bool optionok = int.TryParse(option, out int value);
            if (!optionok)
            {
                Console.WriteLine("Elija una opción");
                runMenu();
            }
            else
            {
                do
                {
                    Console.WriteLine("Elija opción:");
                } while (optionok);
            }
        }
        public static void SeleccionadorEjercicio()
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA BIBLIOTECA ===\n");
            Console.WriteLine("" +
                "1. Agregar libro\n" +
                "2. Mostrar libros\n" +
                "3. Registrar usuario\n" +
                "4. Realizar préstamo\n" +
                "0. Salir\n");
            string seleccion = Console.ReadLine() ?? "0";
            checkSeleccionDel1al10(seleccion);
            switch (seleccion)
            {
                case "1":
                    BibliotecaService p = new BibliotecaService();
                        //p.AgregarLibro();
                    continuarOFinalizar();
                    break;
                case "2":
                    //PresentacionConInterpolacion();
                    continuarOFinalizar();
                    break;
                case "3":
                    //ErrorClasicoConcatenacion();
                    continuarOFinalizar();
                    break;
                case "4":
                    //FormatoDePrecio();
                    continuarOFinalizar();
                    break;
            }

        }
        static void checkSeleccionDel1al10(string texto)
        {
            List<string> opcionesValidas = new List<string>
            {
                "1","2","3","4","5","6","7","8","9","10","0"
            };
            if (!opcionesValidas.Contains(texto))
            {
                Console.WriteLine($"La opcion {texto} no es valida, por favor, seleccione otra");
                SeleccionadorEjercicio();
            }
        }
        static void continuarOFinalizar()
        {
            Console.WriteLine("¿Desea elegir otra opcion? Responda s/n");
            string continuacion = (Console.ReadLine() ?? "n").ToLower();
            if (continuacion != "s" && continuacion != "n")
            {
                Console.WriteLine("Opcion no valida: introduzca s o n");
                continuarOFinalizar();

            }
            else
            {
                if (continuacion == "s")
                {
                    Console.Clear();
                    SeleccionadorEjercicio();
                }
            }

        }



    }
}
