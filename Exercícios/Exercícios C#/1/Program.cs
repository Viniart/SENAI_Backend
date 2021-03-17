using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoatual;
            int anonasc;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            Console.WriteLine("Informe o ano atual: ");
            anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o seu ano de nascimento: ");
            anonasc = int.Parse(Console.ReadLine());

            if(anoatual - anonasc >= 18){
                Console.WriteLine("Você pode votar esse ano, vote!");
            }else{
                Console.WriteLine("Infelizmente você ainda não pode votar.");
            }
        }
    }
}
