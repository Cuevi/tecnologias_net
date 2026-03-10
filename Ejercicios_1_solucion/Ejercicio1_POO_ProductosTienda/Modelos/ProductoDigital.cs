namespace Ejercicio1_POO_ProductosTienda.Modelos;

public class ProductoDigital : Producto
{
    private decimal precioBase {  get; set; }
    public ProductoDigital(string nombre, decimal precioBase)
        : base(nombre, precioBase)
    {
        nombre = Nombre;
        precioBase = PrecioBase;
    }

    public override decimal CalcularPrecioFinal()
    {
        return precioBase;
    }
}
