using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=============================");
            Console.WriteLine("Bem Vindo!");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("=============================");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            string nome;
            string senha;

            do{
            Console.WriteLine("Digite seu nome de usuário: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();
            if(nome==senha){
                Console.WriteLine("Nome de usuário e senha iguais, modifique um deles");
            }
            }while(nome==senha);
            Console.WriteLine("Nome de usuário e senha de acordo.");

        }
    }
}
