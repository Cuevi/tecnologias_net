using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace E_SimplificarCondicionales_GuardClauses
{
    internal class Envios
    {
        //TODO: Repensar para hacerlo más breve y eficiente
        public static double CalcularEnvio(double total, bool esIsla)
        {
            if(total >= 50)
            {
                return esIsla ? total * 2 : total * 5;
            }
            else
            {
                return esIsla ? total * 3 : total * 6;
            }
                
        }

    }
}
