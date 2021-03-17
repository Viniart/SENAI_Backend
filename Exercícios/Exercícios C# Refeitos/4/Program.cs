using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double [10];
            double maiorvalor = valores[1];
            double menorvalor = valores[1];

            for (var i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º valor: ");
                valores[i] = double.Parse(Console.ReadLine());

                if(valores[i] > maiorvalor){
                    maiorvalor = valores[i];
                }
                if(valores[i] < menorvalor){
                    menorvalor = valores[i];
                }
            }
            Console.WriteLine($"O maior valor foi: {maiorvalor}");
            Console.WriteLine($"O menor valor foi: {menorvalor}");
        }
    }
}
