using System;

namespace Laços
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Bem Vindo");
            Console.WriteLine("------------------------------------------------------");
            // Console.Write("Quantas vezes você deseja receber um bom dia?");
            Console.WriteLine("Deseja ver a tabuada de qual número?");
            int resposta = int.Parse(Console.ReadLine());

            // int numeroDeVezes = 0;

            for (int contador = 10; contador >= 0; contador--)
            {
                Console.WriteLine($"{resposta} * {contador} = {resposta * contador}");
                System.Threading.Thread.Sleep(500);
                // Console.WriteLine(contador);
            }
            // do{
            //     // Executado pelo menos uma vez
            //     Console.WriteLine("Bom dia!");

            //     Console.WriteLine("Ainda deseja receber um bom dia?");
            //     resposta = Console.ReadLine();

            //     numeroDeVezes++;

            // } while(resposta == "Sim");
            
            // while(resposta == "Sim")
            // {
            //     Console.WriteLine("Bom dia!!");
            //     // Executado quando condição é verdadeira

            //     // numeroDeVezes = numeroDeVezes + 1; Mesma coisa que abaixo
            //     numeroDeVezes++;
            //     //numeroDeVezes-- para decremento

            //     Console.WriteLine("Ainda deseja receber um bom dia?");
            //     resposta = Console.ReadLine();
            // }
            
            // Console.WriteLine($"Número de vezes: {numeroDeVezes}");
            // Console.WriteLine("Fim, tenha um excelente dia!");
        }
    }
}
