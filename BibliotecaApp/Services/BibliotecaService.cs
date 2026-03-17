using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class BibliotecaService
    {
        static public List<Libro> libros = new();
        public BibliotecaService(){ }
        public void AgregarLibro()
        {
            Console.WriteLine("Escriba un titulo para el libro:");
            string titulo = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba un nombre de autor para el libro:");
            string nombreAutor = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba un categoria para el libro:");
            string categoria = Console.ReadLine() ?? "";
            Console.WriteLine("Escriba la disponibilidad del libro si/no (En caso de dejarlo vacío o no poner 'no' será true):");
            string disponibilidadTexto = Console.ReadLine() ?? "";
            bool disponibilidad = true;
            if (disponibilidadTexto == "no") disponibilidad = false; 
            Autor autorNuevo = new Autor(nombreAutor);
            Categoria categoriaNueva = new Categoria(categoria);
            Libro libroNuevo = new Libro(titulo, autorNuevo, categoriaNueva, disponibilidad);
            libros.Add(libroNuevo);
        }
        public void LibrosRegistrados()
        {
            foreach (Libro libro in libros) 
            {
                string disponibilidadConsola = libro.Disponible ? "si" : "no";
                Console.WriteLine($"Libro: {libro.titulo}, autor: {libro.autor.nombre}, categoria: {libro.categoria.nombre}" +
                    $" disponibilidad: {disponibilidadConsola}");
            }
        }
    }
}
