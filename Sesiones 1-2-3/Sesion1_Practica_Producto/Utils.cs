using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion1_Practica_Producto
{
    internal class Utils
    {
        public static void checkNombreProducto(string producto)
        {
            if (string.IsNullOrEmpty(producto)) throw new Exception($"El nombre del producto es null o vacío. Nombre producto: {producto}");
        }
        public static void checkPrecioNegativoOCero(double precio)
        {
            if (precio <= 0) throw new Exception($"El precio es 0 o negativo. Precio: {precio}");
        }
    }
}
