using System;

namespace _3
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
            int idade;
            double salario;
            string estcivil;
            string confirmacao;

            do{
                do{
                    Console.WriteLine("Digite seu nome: ");
                    nome = Console.ReadLine();
                }while(nome=="");

                do{
                    Console.WriteLine("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());
                }while(idade<0 || idade>150);

                do{
                    Console.WriteLine("Digite seu salário: ");
                    salario = double.Parse(Console.ReadLine());
                }while(salario<0);

                do{
                    Console.WriteLine("Qual seu estado civil? ");
                    Console.WriteLine("s-Solteiro(a), c-Casado(a), v-Viúvo(a), d-Divorciado(a)");
                    estcivil = Console.ReadLine();
                }while(estcivil != "s" && estcivil != "c" && estcivil != "v" && estcivil != "d");

                Console.WriteLine($"Nome: {nome}");
                Console.WriteLine($"Idade: {idade}");
                Console.WriteLine($"Salario: {salario}");
                Console.WriteLine($"Estado Civil: {estcivil}");
                Console.WriteLine("Confirma as informações? (s/n)");
                confirmacao = Console.ReadLine().ToLower();
            }while(confirmacao == "n");

            Console.WriteLine("Obrigado pelas informações, tamo junto!");
        }
    }
}
