using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAcademiaApp.Models
{
    internal class Alumno
    {
        public string nombre {  get; set; }
        public string email { get; set; }
        public int[] notas {  get; set; }
        public Alumno(string nombre, string email, int[] notas) 
        {
            this.nombre = nombre;
            this.email = email;
            this.notas = notas;
        }
        public string toString()
        {
            return $"Nombre: {nombre}, email: {email}";
        }
    }
}
