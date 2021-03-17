using System;

namespace Semáforo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a cor do semáforo:");
            string cordosemaforo = Console.ReadLine();

            string procedencia = "";

            if(cordosemaforo == "vermelho"){
                procedencia = "Pare o carro";
            if(cordosemaforo == "amarelo"){
                procedencia = "Desacelere e pare o carro";
                } 
            }
            else {
                procedencia = "Continue em velocidade constante";
            }

            Console.WriteLine(procedencia);
        }
    }
}
