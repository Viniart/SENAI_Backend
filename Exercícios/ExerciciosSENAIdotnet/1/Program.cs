using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Por favor, digite a sua idade:");
            int idade = int.Parse(Console.ReadLine());
            int meses = idade * 12;
            int semanas = meses * 5;
            int dias = semanas * 7;
            int horas = dias * 24;
            int minutos = horas * 60;

            Console.WriteLine("Sua idade corresponde a: " + meses + " meses " + dias + " dias " + horas + " horas e " + minutos + " minutos.");
        }
    }
}
