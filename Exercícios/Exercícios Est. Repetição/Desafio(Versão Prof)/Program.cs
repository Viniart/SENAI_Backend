using System;

namespace Desafio_Versão_Prof_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 0, 1 e 2 índice dos itens (começa do zero, não do 1)
            string[] produtos = {"maçã", "batata", "cenoura"};
            double[] precos = {1.1,2.3,4.5};
            int[] idades = {16, 17, 17};

            string[] nomesAlunos = new string[5];

            // Console.WriteLine(produtos[1]);

            // Console.WriteLine("Trocar batata por qual item? ");
            // string item = Console.ReadLine();

            // produtos[1] = item;

            // Console.WriteLine(produtos[1]);

            // Console.WriteLine(produtos.Length);

            for (var i = 0; i < produtos.Length; i++)
            {
                // Console.WriteLine(i);
                Console.WriteLine(produtos[i]);
            }
        }
    }
}
