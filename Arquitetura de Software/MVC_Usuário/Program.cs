using System;
using MVC_Usuário.Controllers;

namespace MVC_Usuário
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioController user = new UsuarioController();
            user.Cadastrar();
            user.ListarUsuarios();
        }
    }
}
