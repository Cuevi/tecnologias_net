using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos
{
    public abstract class Cliente
    {
        public string Nombre { get; }
        public Cliente(string nombre) 
        {
            Nombre = nombre;
        }
        public abstract double CalcularDescuento(double total);
    }
}
