using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OCP
{
    public class ClientePremium : Cliente
    {
        public ClientePremium(string nombre) : base(nombre) { }
        public override double CalcularPrecio(double total) => total * 0.80;
    }
}
