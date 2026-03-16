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
        public List<Prestamo> prestamos {  get; set; }
        public void realizarPrestamo(Prestamo prestamo)
        {
            if(prestamo.libro.Disponible == true)
            {
                prestamos.Add(prestamo);
            }
            else
            {
                Console.WriteLine("El prestamo no se puede realizar porque el libro no está disponible");
            }   
        }
    }
}
