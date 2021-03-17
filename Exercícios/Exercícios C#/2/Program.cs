using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;
            int litros;
            double gasolina;
            double alcool;
            double precofinal = 0;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            Console.WriteLine("Qual tipo de combustível comprado? (G para gasolina e A para álcool)");
            tipo = Console.ReadLine().ToUpper();

            Console.WriteLine("Quantos litros foram comprados?");
            litros = int.Parse(Console.ReadLine());

            
            switch(tipo){

                case "G":
                gasolina = 5.3 * litros;
                if(litros < 20){
                    precofinal = gasolina * 0.96;
                } else{
                    precofinal = gasolina * 0.94;
                }
                break;

                case "A":
                alcool = 4.9 * litros;
                if(litros < 20){
                    precofinal = alcool * 0.97;
                } else{
                    precofinal = alcool * 0.95;
                }
                break;

                default:
                Console.WriteLine("Valor inválido");
                break;
            }
            Console.WriteLine($"O preço final é: R$:{precofinal}");
        }
    }
}
