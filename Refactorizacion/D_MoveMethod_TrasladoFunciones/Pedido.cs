using RefactorD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_MoveMethod_TrasladoFunciones
{
    internal class Pedido
    {
        private double precio;
        private Cliente cliente;
        public double Total;
        public Pedido(Cliente cliente, double total) 
        {
            this.cliente = cliente;
            Total = total;
        }

        public double TotalFinal()
        {
            return cliente.CalcularDescuento(Total);
        }
    }
}
