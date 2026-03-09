using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_ISP 
{
    internal class Robot : ITrabajador
    {
        private string nombre;
        public Robot(string nombre)
        {
            this.nombre = nombre;
        }

        public void Trabajar()
        {
            Console.WriteLine($"{nombre} trabaja");
        }
    }
}
