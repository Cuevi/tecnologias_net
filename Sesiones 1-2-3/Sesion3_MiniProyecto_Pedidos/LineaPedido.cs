using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos
{
    internal class LineaPedido
    {
        public string nombre;
        public int cuantia;
        public double precio;
        public LineaPedido(string nombre, int cuantia, double precio) 
        { 
            this.nombre = nombre;
            this.cuantia = cuantia;
            this.precio = precio;
        }
    }
}
