using System.Linq.Expressions;

namespace RefactorF
{
    internal class Edades
    {
        public static string ClasificarEdad(int edad)
        {
            string result = string.Empty;
            if (edad < 0)
            {
                Console.WriteLine($"Edad negativa {edad}");
            }
            else
            {
                result = edad < 18 ? "Menor de edad" : "Mayor de edad"; ;
            }
            return result;
        }
    }
}