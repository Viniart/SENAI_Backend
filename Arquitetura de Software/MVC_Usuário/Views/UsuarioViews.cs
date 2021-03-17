using System;
using System.Collections.Generic;
using MVC_Usuário.Models;

namespace MVC_Usuário.Views
{
    public class UsuarioViews
    {
        
        public void Listar(List<Usuario> usuarios){
            foreach (var item in usuarios)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Nome: {item.Senha}");
                Console.WriteLine($"Nome: {item.Email}");
                Console.WriteLine($"Nome: {item.ID}");
                Console.WriteLine();
            }
        }

        public Usuario CadastrarUsuario()
        {
            Random id = new Random();

            Usuario usuario = new Usuario();

            Console.WriteLine($"Digite um nome:");
            usuario.Nome = Console.ReadLine();

            Console.WriteLine($"Digite uma senha:");
            usuario.Senha = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite um email:");
            usuario.Email = Console.ReadLine();

            usuario.ID = id.Next(-9999, 9999);

            return usuario;
        }
    }
}