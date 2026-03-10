namespace Ejercicio1_POO_ProductosTienda.Modelos;

public class ProductoFisico : Producto
{
    private decimal GastosEnvio { get; set; }
    private decimal precioBase { get; set; }

    public ProductoFisico(string nombre, decimal precioBase, decimal gastosEnvio)
        : base(nombre, precioBase)
    {
        precioBase = PrecioBase;
        gastosEnvio = GastosEnvio;
    }

    public override decimal CalcularPrecioFinal()
    {
        return precioBase + GastosEnvio;
    }
}
