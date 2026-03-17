using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Models
{
    public class Libro 
    {
        public string titulo {  get; set; }
        public Autor autor {  get; set; }
        public Categoria categoria {  get; set; }
        public bool Disponible {  get; set; }
        public Libro(string titulo, Autor autor, Categoria categoria, bool disponible = true)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.categoria = categoria;
            Disponible = disponible;
        }
    }
}
