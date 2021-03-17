using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anonasc;
            int ano;

            Console.WriteLine("Digite o ano atual: ");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu ano de nascimento: ");
            anonasc = int.Parse(Console.ReadLine());

            if((ano - anonasc) >= 18){
                Console.WriteLine("Você pode votar esse ano, vote!");
            }else{
                Console.WriteLine("Você ainda não pode votar.");
            }
        }
    }
}
