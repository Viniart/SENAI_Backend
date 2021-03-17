using System;

namespace Codacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // || Operador lógico (OU), && (E)
            // Para participar do time de CS o aluno deve; ter média >= 80 e faltas <= 10% dos dias letivos
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Bem vindo a seletiva para o time de Counter Strike!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Você gostaria de participar? Sim ou Não");
            string resposta = Console.ReadLine();
            if(resposta == "Sim"){
                    Console.WriteLine("Que legal! Agora vamos analisar seu currículo");
                    Console.WriteLine("Insira sua média escolar");
                    int media = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a sua quantidade de faltas");
                    int faltas = int.Parse(Console.ReadLine());
                    if(media >= 50 && faltas <= 10){
                        Console.WriteLine("Parabéns, seja bem vindo!");
                    }else{
                        Console.WriteLine("Que pena, você precisa melhorar suas notas e/ou faltas");
                    } //Fim if caso queira participar
            }else{
                Console.WriteLine("Beleza, Passar bem!");
            } //Fim if
        }
    }
}
