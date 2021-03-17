using System;
using T.Classes;

namespace T
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interface - contrato das ações q terei em uma outra classe
            // Create, Read, Update and Delete (CRUD)
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto();
            p1.Codigo = 123;
            p1.Nome = "Playstation 5";
            p1.Preco = 10000;
            
            Produto p2 = new Produto();
            p2.Codigo = 124;
            p2.Nome = "Xbox Series X";
            p2.Preco = 5000;

            Produto p3 = new Produto();
            p3.Codigo = 125;
            p3.Nome = "Nintendo Switch";
            p3.Preco = 3000;

            cart.Cadastrar(p1);
            cart.Cadastrar(p2);

            cart.Listar();
            Console.ForegroundColor = ConsoleColor.Blue;
            cart.Alterar(p2.Codigo, p3);
            cart.Listar();

            Console.ForegroundColor = ConsoleColor.Red;
            cart.Delete(p1.Codigo);
            cart.Listar();

            Console.ResetColor();

        }
    }
}
