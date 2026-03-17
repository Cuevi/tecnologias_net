using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Prestamo
    {
        public Libro libro {  get; set; }
        public Usuario usuario {  get; set; }
        public DateTime fechaPrestamo {  get; set; }
        public Prestamo(Libro libro, Usuario usuario)
        {
            this.libro = libro;
            this.usuario = usuario;
            this.fechaPrestamo = DateTime.Now;
        }
    }
}
