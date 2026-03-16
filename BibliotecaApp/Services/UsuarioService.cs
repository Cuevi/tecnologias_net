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
        public List<Usuario> usuarios { get; set; }
        public void registrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }
    }
}
