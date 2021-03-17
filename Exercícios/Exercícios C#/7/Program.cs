using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[15];

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            for (var i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Escreva o {i+1}º número: ");
                num[i] = double.Parse(Console.ReadLine());
            }
            for (var i = 14; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
