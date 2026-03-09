using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    internal class Aguila : Ave, IAveVoladora
    {
        public Aguila(string nombre) : base(nombre)
        {
            nombre = Nombre;
        }
        public void Volar()
        {
            Console.WriteLine($"Vuela");
        }
        public override void Moverse()
        {
            Console.WriteLine("Aguila si vuela");
        }
    }
}
