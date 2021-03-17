using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Revisão da SEMANA
            // Hard code; variável já declarada no código, sem imput do usuário
            
            Console.WriteLine("Quantos nomes deseja colocar na lista?");
            int quan = int.Parse(Console.ReadLine());

            string[] nomes = new string[quan];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º nome:");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("------Listando com Foreach------");
            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
