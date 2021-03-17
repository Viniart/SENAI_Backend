using System;

namespace Estática
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas?
            // Quando precisarmos de uma solução que pode servir para qualquer tipo de aplicação

            // Quando não a usamos?
            // Quando tivermos objetos/classes que são específicas de uma aplicação

            // Console.WriteLine( Math.Pow(2, 5));
            // este método tmb tem q ter static 
            Testar();

            Console.WriteLine( Conversor.ConverterDolarParaReal(3f));

            Console.WriteLine( Conversor.ConverterRealParaDolar(200f));
        }

        static void Testar(){}
    }
}
