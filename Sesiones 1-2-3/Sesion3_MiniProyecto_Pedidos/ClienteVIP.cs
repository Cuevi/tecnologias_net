using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion3_MiniProyecto_Pedidos
{
    internal class ClienteVIP : Cliente
    {
        private string nombre;
        public ClienteVIP(string nombre) 
        { 
            this.nombre = nombre;  
        }
    }
}
