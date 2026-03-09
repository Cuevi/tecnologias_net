using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP
{
    internal class Pinguino : Ave
    {
        public Pinguino(string nombre) : base(nombre)
        {
            nombre = Nombre;
        }

        public override void Moverse()
        {
            Console.WriteLine("Pinguino no vuela");
        }
    }
}
