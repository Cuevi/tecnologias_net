using BibliotecaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Services
{
    public class UsuarioService
    {
        static public List<Usuario> usuarios = new();
        public void registrarUsuario()
        {
            Console.WriteLine("Introduzca el nombre de usuario");
            string nombre = Console.ReadLine() ?? "";
            Console.WriteLine("Introduzca el DNI de usuario");
            string DNI = Console.ReadLine() ?? "";
            Usuario user = new(nombre, DNI);
            usuarios.Add(user);
            Console.WriteLine($"El usuario: {nombre}, con DNI: {DNI} ha sido añadido correctamente");
            Console.WriteLine("Para continuar pulse Enter");
            Console.ReadLine();
        }
    }
}
