using System;

namespace Exercício
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            float[] nota1 = new float[10];
            float[] nota2 = new float[10];
            float[] nota3 = new float[10];
            float[] nota4 = new float[10];
            float[] media = new float[10];
            float mediageral = 0;
            float mediag;
            int aprovados = 0;
            int reprovados = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {i+1}º Nome: ");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Digite a 1ª nota do aluno: ");
                nota1[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 2ª nota do aluno: ");
                nota2[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 3ª nota do aluno: ");
                nota3[i] = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite a 4ª nota do aluno: ");
                nota4[i] = float.Parse(Console.ReadLine());

                media[i] = Média(nota1[i], nota2[i], nota3[i], nota4[i]);
                if(media[i]>=7){
                    aprovados = aprovados + 1;
                } else{
                    reprovados = reprovados + 1;
                }
                Console.Write("A Média do aluno é: ");
                Console.WriteLine(Média(nota1[i], nota2[i], nota3[i], nota4[i]));
                mediageral = mediageral + media[i];
            }
            mediag = mediageral / 10;
            Console.WriteLine($"O número de aprovados é: {aprovados}");
            Console.WriteLine($"O número de reprovados é: {reprovados}");

            Console.WriteLine($"A média geral é: {mediag}");
            

            float Média(float nota1, float nota2, float nota3, float nota4){
                float media = (nota1 + nota2 + nota3 + nota4)/4;
                return media;
            }

            // foreach (var item in nomes)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}
