using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string DNI { get; set; }

        public Usuario(string nombre, string DNI)
        {
            this.nombre = nombre;
            this.DNI = DNI;
        }
    }
}
