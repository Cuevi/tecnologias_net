using System;

namespace SOLID_OCP
{
    // Cliente VIP: 20% descuento.
    public class ClienteNormal : Cliente
    {
        public ClienteNormal(string nombre) : base(nombre) { }
        public override double CalcularPrecio(double total) => total * 0.80;
    }
}
