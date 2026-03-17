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
        //TODO: Faltan por añadir validaciones y un camino por defecto para cuando no se selecciona una de 
        //las opciones disponibles
        public static void SeleccionadorEjercicio(BibliotecaService bibliotecaService, UsuarioService usuarioService, PrestamoService prestamoService)
        {
            bool continuar = false;
            do
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
                switch (seleccion)
                {
                    case "1":
                        bibliotecaService.AgregarLibro();
                        Console.WriteLine("¿Desea continuar? s/n");
                        continuar = continuarSioNo(Console.ReadLine() ?? "");
                        break;
                    case "2":
                        bibliotecaService.LibrosRegistrados();
                        Console.WriteLine("¿Desea continuar? s/n");
                        continuar = continuarSioNo(Console.ReadLine() ?? "");
                        break;
                    case "3":
                        usuarioService.registrarUsuario();
                        Console.WriteLine("¿Desea continuar? s/n");
                        continuar = continuarSioNo(Console.ReadLine() ?? "");
                        break;
                    case "4":
                        prestamoService.realizarPrestamo();
                        Console.WriteLine("¿Desea continuar? s/n");
                        continuar = continuarSioNo(Console.ReadLine() ?? "");
                        break;
                    case "0":
                        continuar = false;
                        break;
                }
            } while (continuar);
        }
        static bool continuarSioNo(string texto)
        {
            bool result = false;
            if (texto.ToLower() == "s" || texto.ToLower() == "si") result = true;
            return result;
        }
    }
}
