using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double maiorvalor;
            double menorvalor;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            Console.WriteLine("Digite o primeiro valor: ");
            valor = double.Parse(Console.ReadLine());
            maiorvalor = valor;
            menorvalor = valor;

            for (var i = 1; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i}º valor: ");
                valor = double.Parse(Console.ReadLine());

                if(valor > maiorvalor){
                    maiorvalor = valor;
                }if(valor < menorvalor){
                    menorvalor = valor;
                }
            }
            Console.WriteLine($"O maior valor é {maiorvalor} e o menor é {menorvalor}");
        }
    }
}
