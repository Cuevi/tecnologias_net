using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos
{
    internal class PedidoPrinter
    {
        public PedidoPrinter() { }
        public void Imprimir(Pedido pedido)
        {
            foreach (var linea in pedido.Lineas)
            {
                Console.WriteLine($"Producto: {linea.nombre}, cuantía: {linea.cuantia}, precio: {linea.precio}");
            }
                
            
        }
    }
}
