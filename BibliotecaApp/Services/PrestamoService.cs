using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class PrestamoService
    {
        public List<Prestamo> prestamos = new List<Prestamo>();
        public void realizarPrestamo()
        {
            //TODO: Se puede mejorar usando usuarios y libros existentes. Mejora del proyecto
            Console.WriteLine("Escriba un titulo para el libro:");
            string titulo = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba un nombre de autor para el libro:");
            string nombreAutor = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba un categoria para el libro:");
            string categoria = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba la disponibilidad del libro si/no (En caso de dejarlo vacío o no poner 'no' será true):");
            string disponibilidadTexto = Console.ReadLine() ?? "";
            bool disponibilidad = false;
            Autor autorNuevo = new Autor(nombreAutor);
            Categoria categoriaNueva = new Categoria(categoria);
            Libro libroNuevo = new Libro(titulo, autorNuevo, categoriaNueva, disponibilidad);
            Console.WriteLine("Introduzca el nombre de usuario");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca el DNI de usuario");
            string DNI = Console.ReadLine() ?? "";
            Usuario user = new(nombre, DNI);
            Prestamo nuevoPrestamo = new Prestamo(libroNuevo, user);
            Console.WriteLine("El prestamo ha sido añadido correctamente");
            Console.WriteLine($"El usuario asignado al prestamo tiene nombre: {nombre} con DNI: {DNI}");
            Console.WriteLine($"El libro asignado al prestamo tiene titulo {titulo} nombre de autor" +
                $" {nombreAutor}");
            Console.WriteLine("Para continuar pulse Enter");
            Console.ReadLine();
        }
    }
}
