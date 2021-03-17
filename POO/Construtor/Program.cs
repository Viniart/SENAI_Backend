using System;
using Construtor.classes;

namespace Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            produto produto1 = new produto();
            Console.WriteLine($"Codigo = {produto1.Codigo} Nome{produto1.Nome ?? "null"}" + 
            $"Descricao={produto1.Descricao ?? "null"} Estoque={produto1.Estoque}");
            produto produto2 = new produto(1);
            Console.WriteLine($"Codigo = {produto1.Codigo} Nome{produto1.Nome ?? "null"}" + 
            $"Descricao={produto1.Descricao ?? "null"} Estoque={produto1.Estoque}");
            produto produto3 = new produto(1, "Produto 3", "Este é o produto 3", 20);
            Console.WriteLine($"Codigo = {produto1.Codigo} Nome{produto1.Nome ?? "null"}" + 
            $"Descricao={produto1.Descricao ?? "null"} Estoque={produto1.Estoque}");
            Console.ReadLine();
        }
    }
}
