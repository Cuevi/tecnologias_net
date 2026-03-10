using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1_POO_ProductosTienda.Modelos;

public abstract class Producto
{
    private string _nombre;
    private decimal _precioBase;

    public Producto(string nombre, decimal precioBase)
    {
        checkNombre(nombre);
        _nombre = nombre;
        _precioBase = precioBase;
    }
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            checkNombre(value);
            _nombre = value;
        }
    }

    public decimal PrecioBase
    {
        get { return _precioBase; }
        set
        {
            checkPrecio(value);
            _precioBase = value;
        }
    }

    //Nota: Se puede aislar por otro lado los checks en otra clase "Utils" por ejemplo, donde se hacen las comprobaciones
    public void checkNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre no puede estar vacío.");
    }
    public void checkPrecio(decimal precio)
    {
        if (precio < 0) throw new ArgumentException("El precio no puede ser negativo.");
    }

    public abstract decimal CalcularPrecioFinal();
}
