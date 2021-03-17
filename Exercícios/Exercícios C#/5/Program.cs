using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            // Console.WriteLine("Deseja ver a tabuada de qual número?");
            // num = int.Parse(Console.ReadLine());

            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine("--------------");
                for (var j = 0; j <= 10; j++)
                {
                tabuada = j * i;
                Console.WriteLine($" {j} x {i} = {tabuada}");
                }
            }
        }
    }
}
