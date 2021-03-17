using MVC_Usuário.Models;
using MVC_Usuário.Views;

namespace MVC_Usuário.Controllers
{
    public class UsuarioController
    {
        Usuario usuario = new Usuario();

        UsuarioViews usuarioView = new UsuarioViews();

        public void ListarUsuarios()
        {
            usuarioView.Listar(usuario.Ler());
        }

        public void Cadastrar()
        {
            usuario.InserirUsuario(usuarioView.CadastrarUsuario());
        }
    }
}