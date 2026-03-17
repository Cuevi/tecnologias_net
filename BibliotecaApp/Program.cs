using BibliotecaApp.Services;
using BibliotecaApp.Utils;

namespace BibliotecaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BibliotecaService bibliotecaService = new BibliotecaService();
            UsuarioService usuarioService = new UsuarioService();
            PrestamoService prestamoService = new PrestamoService();
            Menu.SeleccionadorEjercicio(bibliotecaService, usuarioService, prestamoService);
        }
    }
}