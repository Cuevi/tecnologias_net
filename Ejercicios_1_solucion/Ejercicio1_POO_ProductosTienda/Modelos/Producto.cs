namespace Ejercicio1_POO_ProductosTienda.Modelos;

public abstract class Producto
{
    private string Nombre;
    private decimal PrecioBase;

    public Producto(string nombre, decimal precioBase)
    {
        checkNombre(nombre);
        Nombre = nombre;
        PrecioBase = precioBase;
    }

    //Nota: Se puede aislar por otro lado el check
    public void checkNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
    }

    public abstract decimal CalcularPrecioFinal();
}
