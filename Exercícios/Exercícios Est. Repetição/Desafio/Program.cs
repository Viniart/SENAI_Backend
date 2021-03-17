using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double f1 = 0,f2 = 1,f3,contagem;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=============================");
            Console.WriteLine("Bem Vindo!");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Deseja ver a sequencia Fibonacci? (s/n)");
            string resposta = Console.ReadLine();
                if(resposta == "s"){

                Console.WriteLine($"{f1}");
                Console.WriteLine($"{f2}");
                for(contagem=2;contagem<15;++contagem){
                    f3=f1+f2;
                    Console.WriteLine($"{f3}");
                    f1=f2;
                    f2=f3;
                }
            }
            Console.WriteLine("Obrigado e até a próxima!");
        }
    }
}
