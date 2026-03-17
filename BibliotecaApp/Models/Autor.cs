using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Autor
    {
        public string nombre {  get; set; }
        public Autor(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
