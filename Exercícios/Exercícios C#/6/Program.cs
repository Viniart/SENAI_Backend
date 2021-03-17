using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            string nomebusca;
            bool busca = false;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º nome: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Digite o nome que deseja buscar :");
            nomebusca = Console.ReadLine();

            for (var i = 0; i < nomes.Length; i++)
            {
                if(nomes[i] == nomebusca){
                    Console.WriteLine("ACHEI");
                    busca = true;
                    break;
                }
            }
            if(busca == false){
                Console.WriteLine("NÃO ACHEI");
            }
        }
    }
}
