using System;
using RFZ.Classes;

namespace RFZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "Playstation 5", 9999.99f);
            Produto p2 = new Produto(2, "Xbox Series X", 4999.99f);
            Produto p3 = new Produto(3, "Xbox Series S", 2999.99f);
            Produto p4 = new Produto(4, "Nintendo Switch", 2999.99f);
            Produto p5 = new Produto(5, "PC Low-End", 2499.99f);
            Produto p6 = new Produto(6, "PC Medium-End", 3999.99f);
            Produto p7 = new Produto(7, "PC High-End", 6999.99f);

            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);

            cart.MostrarProdutos();
            Console.ForegroundColor = ConsoleColor.Green;

            cart.AlterarProduto(4, p5);
            cart.MostrarProdutos();

            cart.DeletarProduto(p2);
            cart.AdicionarProduto(p6);
            cart.AdicionarProduto(p7);
            Console.ForegroundColor = ConsoleColor.Red;
            cart.MostrarProdutos();
            cart.MostrarTotal();


        }
    }
}
