using System;

namespace Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarações de Variáveis
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;
            //Dados das Passagens
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("---- Sistema de Passagens ----");
            Console.WriteLine("------------------------------");

            //Login
            do
            {
                Console.WriteLine("Digite a senha para acessar o sistema");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);
            } while (!senhaValida);

            Console.WriteLine("Senha válida, continuando com o programa");

            //Menu
            do
            {
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro de Passagens");
                        do
                        {
                            if(contador < 5){
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro: ");
                            nomes[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o destino:");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a origem:");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a data do Vôo:");
                            data[contador] = Console.ReadLine();

                            contador++;
                            }else{
                                Console.WriteLine("Limite de cadastros excedido");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar um novo passageiro? (s/n, limite de até 5 cadastros!)");
                            resposta = Console.ReadLine().ToLower();


                        } while (resposta == "s");
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Listar Passagens");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro: {nomes[i]}, Origem{origem[i]} com Destino para {destino[i]} e data do Vôo: {data[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por viajar na SENAI Airlines!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        break;
                }
                
                
            } while (escolha != 0);

            //Funções
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("Senha inválida, tente novamente.");
                    return false;
                }
                //https://discord.gg/RAn8E8u7
            }
        }
    }
}
