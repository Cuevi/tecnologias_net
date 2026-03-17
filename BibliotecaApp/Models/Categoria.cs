using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Podria mejorarse usando un tipo enumerado
namespace BibliotecaApp.Models
{
    public class Categoria
    {
        public string nombre {  get; set; }
        public Categoria(string nombre) 
        {
            this.nombre = nombre;
        }
    }
}
