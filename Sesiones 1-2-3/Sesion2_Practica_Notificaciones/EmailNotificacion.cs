using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2_Practica_Notificaciones 
{
    internal class EmailNotificacion : INotificacion
    {
        public EmailNotificacion()
        {

        }

        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"Notificación EMAIL - Destinatario: {destinatario}, mensaje: {mensaje}");
        }
    }
}
