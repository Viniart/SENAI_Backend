using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double quant;
            double preco;
            double total;
            double desc = 0;
            double totalpag;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            Console.WriteLine("Digite o nome do produto: ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a quantidade adquirida? (apenas números) ");
            quant = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço unitário? (apenas números) ");
            preco = double.Parse(Console.ReadLine());

            total = quant * preco;

            if(quant <= 5){
                desc = total * 0.02;
            }else if(quant > 5 && quant <= 10){
                desc = total * 0.03;
            }else if(quant > 10){
                desc = total * 0.05;
            }
            totalpag = total - desc;

            Console.WriteLine($"O total equivale a: R${total}");
            Console.WriteLine($"O desconto é: R${desc}");
            Console.WriteLine($"O total a pagar é: R${totalpag}");
        }
    }
}
