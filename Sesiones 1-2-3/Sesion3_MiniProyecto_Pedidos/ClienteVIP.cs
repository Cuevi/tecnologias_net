using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos
{
    public class ClienteVIP : Cliente
    {
        private string nombre;
        public ClienteVIP(string nombre) : base(nombre)
        { 
            this.nombre = nombre;  
        }
        public override double CalcularDescuento(double total) => total * 0.20;
    }
}
