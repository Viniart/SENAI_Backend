using System;
using Encapsulamento.classes;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard mc = new MasterCard();
            mc.NomeTitular = "Carlos Eduardo Tsukamoto";

            mc.Numero = "123456778"; // Aqui foi utilizado o SET

            mc.Cvv = "1234";
            
            mc.Bandeira = "MasterCard";
            Console.WriteLine($"O titular {mc.NomeTitular} - o Token {mc.Token} - {mc.Cvv}"); // Aqui foi utilizado o GET

        }
    }
}
