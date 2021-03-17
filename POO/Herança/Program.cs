using System;
using Herança.Classes;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();

            //Atribuímos um cpf ao objeto
            pf.cpf = "000.000.000-00";

            pf.nome = "Paulo";

            //Chamamos nosso método de saudação
            Console.WriteLine(pf.DarBoasVindas( pf.nome ));

            //Chamamos nosso método de validação de subclasse
            Console.WriteLine(pf.ValidarCPF(pf.cpf));

        }
    }
}
