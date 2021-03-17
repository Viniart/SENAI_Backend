using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            do{
                Console.WriteLine("Digite uma nota entre 0 e 10: ");
                nota = int.Parse(Console.ReadLine());

                if(nota < 0 || nota > 10){
                    Console.WriteLine("Número Inválido");
                }

            }while(nota < 0 || nota > 10);
            Console.WriteLine("Número Aceito");
        }
    }
}
