using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Prestamo
    {
        private Libro libro {  get; set; }
        private Usuario usuario {  get; set; }
        private DateTime fechaPrestamo {  get; set; }
        public Prestamo(Libro libro, Usuario usuario, DateTime fechaPrestamo)
        {
            this.libro = libro;
            this.usuario = usuario;
            this.fechaPrestamo = DateTime.Now;
        }
    }
}
