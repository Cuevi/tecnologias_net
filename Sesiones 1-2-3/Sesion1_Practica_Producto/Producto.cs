namespace Sesion1_Practica_Producto
{
    internal class Producto
    {
        public string producto;
        public double precio;

        public Producto(string producto, double precio)
        {
            this.producto = producto;
            this.precio = precio;
        }

        public static void MostrarInfo() 
        {
            //Console.WriteLine($"El producto: {producto}, El precio: {precio}");
        }

    }
}