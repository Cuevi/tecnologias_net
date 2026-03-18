using GestorAcademiaApp.Utils;

namespace GestorAcademiaApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Inicializacion.DataPersistance();
            Inicializacion.ImportData();
        }
    }
}
