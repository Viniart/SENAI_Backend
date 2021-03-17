using System;
using ObjComoArgumento.Classes;

namespace ObjComoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(1, "Red Dead Redemption", 199.90f);
            Produto p2 = new Produto(2, "GTA V", 56.90f);
            Produto p3 = new Produto(3, "Detroit: Become Human", 120.50f);
            Produto p4 = new Produto(4, "Celeste", 22.90f);

            Carrinho cart = new Carrinho();
            cart.AdicionarProduto(p1);
            cart.AdicionarProduto(p2);
            cart.AdicionarProduto(p3);
            cart.AdicionarProduto(p4);

            cart.MostrarProdutos();

            Produto p5 = new Produto(5, "GTA San Andreas", 120f);

            cart.AlterarItem(1, p5);

            cart.MostrarProdutos();
        }
    }
}
