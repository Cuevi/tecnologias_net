using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorVehiculos
{
    public class Vehiculo
    {
        private string marca;
        private string modelo;

        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Vehiculo: {marca} {modelo}");
        }

    }
}
