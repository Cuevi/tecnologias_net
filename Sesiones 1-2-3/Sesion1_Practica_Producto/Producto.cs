namespace Sesion1_Practica_Producto
{
    internal class Producto
    {
        private string producto;
        private double precio;

        public Producto(string producto, double precio)
        {
            Utils.checkNombreProducto(producto);
            Utils.checkPrecioNegativoOCero(precio);
            this.producto = producto;
            this.precio = precio;
        }

        public void MostrarInfo() 
        {
            Console.WriteLine($"El producto: {producto}, El precio: {precio}");
        }

        public void AplicarDescuento(double descuento)
        {
            precio *= (1-descuento);
        }

    }
}