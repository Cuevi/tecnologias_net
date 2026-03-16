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
        public List<Libro> libros;
        public BibliotecaService()
        {

        }
        public void AgregarLibro(Libro libro)
        {
            //titulo, autor (nombre), categoria, Disponible
            Console.WriteLine("")
            libros.Add(libro);
        }
        public List<Libro> LibrosRegistrados()
        {
            return libros;
        }
    }
}
