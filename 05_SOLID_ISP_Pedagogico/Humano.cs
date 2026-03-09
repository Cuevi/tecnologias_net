using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP
{
    internal class Humano : ITrabajador, IComedor
    {
        private string nombre;

        public Humano(string nombre)
        {
            this.nombre = nombre;
        }

        public void Comer()
        {
            Console.WriteLine($"{nombre} come");
        }

        public void Trabajar()
        {
            Console.WriteLine($"{nombre} trabaja");
        }
    }
}
