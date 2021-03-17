using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Por favor, digite seu ano de nascimento: ");
            int anonasc = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, digite o ano atual");
            int anoatual = int.Parse(Console.ReadLine());

            int idade = anoatual - anonasc;
            int idadesemana = idade * 60;

            Console.WriteLine("Você tem " + idade + " anos, e sua idade em semanas é: " + idadesemana);
        }
    }
}
