using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("O intuito desse programa é informar o reajuste salarial");
            Console.WriteLine("Por favor, informe seu salário (apenas números): ");
            double salario = double.Parse(Console.ReadLine());

            double salarioreaj = salario * 1.3;

            if(salario < 500){
                Console.WriteLine("Seu salário será reajustado, o novo valor é: " + salarioreaj);
            } else{
                Console.WriteLine("Seu salário não foi reajustado pois você ganha mais de 500 Reais");
            }
        }
    }
}
