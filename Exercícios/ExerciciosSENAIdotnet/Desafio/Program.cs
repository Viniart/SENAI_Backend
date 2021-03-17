using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("O intuito desse programa é informar sua categoria de natação baseado na sua idade");
            Console.WriteLine("Por favor informe sua idade (apenas números):");
            int idade = int.Parse(Console.ReadLine());

            if(idade >=5 && idade <=7){
                Console.WriteLine("Você faz parte da categoria Infantil A.");
                }
            else if(idade >=8 && idade <=10){
                Console.WriteLine("Você faz parte da categoria Infantil B.");
                }
            else if(idade >=11 && idade <=13){
                Console.WriteLine("Você faz parte da categoria Juvenil A.");
                }
            else if(idade >=14 && idade <=17){
                Console.WriteLine("Você faz parte da categoria Juvenil B.");
                }
            else{
                Console.WriteLine("Você faz parte da categoria Sênior.");
            }
        }
    }
}
