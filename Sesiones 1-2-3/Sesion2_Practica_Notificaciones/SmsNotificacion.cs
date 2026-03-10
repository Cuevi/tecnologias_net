using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion2_Practica_Notificaciones
{
    internal class SmsNotificacion : INotificacion
    {
        public SmsNotificacion()
        {

        }

        public void Enviar(string destinatario, string mensaje)
        {
            Console.WriteLine($"Notificación SMS - Destinatario: {destinatario}, mensaje: {mensaje}");
        }
    }
}
