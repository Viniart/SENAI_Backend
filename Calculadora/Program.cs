using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Perguntar a operação
            Console.WriteLine("Qual operação deseja realizar? \nSoma, Subtração, Multiplicação, Divisão");
            string operacao = Console.ReadLine().ToUpper();
            // To Upper/ To Lower - maiusculo, minusculo
            
            // Pedir o primeiro número
            Console.WriteLine("Digite o 1º número:");
            float num1 = float.Parse(Console.ReadLine());

            // Pedir o segundo número
            Console.WriteLine("Digite o 2º número:");
            float num2 = float.Parse(Console.ReadLine());

            // Fazer o cálculo
            // f - Sufixo fo float
            float resultado = 0f;

            // if(operacao == "Soma" || operacao == "soma")
            // {
            //     resultado = num1 + num2;
            // }else if(operacao == "Subtração" || operacao == "subtracao")
            // {
            //     resultado = num1 - num2;
            // }
            // else if(operacao == "Multiplicação" || operacao == "multiplicacao")
            // {
            //     resultado = num1 * num2;
            // }
            // else if(operacao == "Divisao" || operacao == "divisao")
            // {
            //     resultado = num1 / num2;
            // }
            // else
            // {
            //     Console.WriteLine("Operação inválida");
            // }

            switch(operacao){

                case "SOMA":
                    resultado = num1 + num2;
                    break;

                case "SUBTRAÇÃO":
                    resultado = num1 - num2;
                    break;

                case "MULTIPLICAÇÃO":
                    resultado = num1 * num2;
                    break;

                case "DIVISÃO":
                    resultado = num1 / num2;
                    break;

                default:
                    operacao = "invalida";
                    Console.WriteLine("Operação Inválida");
                    break;
            }

            // Mostrar o resultado

            // Concatenação
            // Console.WriteLine("Cálculo :" + num1 + " com "  + num2 + " = " + resultado);

            // Interpolação
            if(operacao != "invalida")
            // != diferente de
            Console.WriteLine($"Cálculo : {num1} com {num2} = {resultado} ");
        }
    }
}
