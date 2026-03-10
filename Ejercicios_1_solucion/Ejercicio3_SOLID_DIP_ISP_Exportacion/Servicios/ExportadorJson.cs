using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_SOLID_DIP_ISP_Exportacion.Servicios
{
    public class ExportadorJson : IExportador
    {
        public void Exportar(string contenido)
        {
            Console.WriteLine($"Json generado: {contenido}");
        }
    }
}
