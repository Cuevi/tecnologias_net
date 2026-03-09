using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID_SRP
{
    internal class FacturaRepository
{   
        public void Guardar(Factura factura)
        {
            Console.WriteLine("=== Copia en repositorio ===");
            Console.WriteLine("===============");
        }
        
}
}
