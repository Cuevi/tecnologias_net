using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_POO_ProductosTienda.Modelos
{
    public class ProductoReacondicionado : Producto
    {
        private decimal GastosEnvio { get; set; }
        private decimal precioBase { get; set; }
        private int piezas { get; set; }
        private double precioPieza { get; set; }

        public ProductoReacondicionado(string nombre, decimal precioBase, decimal gastosEnvio, int piezas,double precioPieza)
            : base(nombre, precioBase)
        {
            precioBase = PrecioBase;
            gastosEnvio = GastosEnvio;
            this.piezas = piezas;
            this.precioPieza = precioPieza;
        }

        public override decimal CalcularPrecioFinal()
        {
            return precioBase + GastosEnvio + (decimal)(piezas * precioPieza);
        }
    }
}
