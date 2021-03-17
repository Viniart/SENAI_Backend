using System;
using System.Collections.Generic;
using ListaObjetos.Classes;

namespace ListaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> produtos = new List<Produto>();

            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.56f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 4522.56f));
            produtos.Add(new Produto(4, "Sansung", 5522.56f));
            produtos.Add(new Produto(5, "Motorola 68", 6522.56f));

            Produto p1 = new Produto();
            p1.Codigo = 67;
            p1.Nome = "Iphone XII";
            p1.Preco = 8952.52f;    

            produtos.Add(p1);

            foreach (Produto p in produtos)
            {
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Codigo);
                Console.WriteLine(p.Preco);
            }

            produtos.RemoveAt(3);

            produtos.RemoveAll(x => x.Nome == "Apple Watch");

            //Remoção feita
            foreach (Produto p in produtos)
            {
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Codigo);
                Console.WriteLine(p.Preco);
            }
        }
    }
}
