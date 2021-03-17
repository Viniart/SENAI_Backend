using System;

namespace Aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando objeto

            Personagem jogador1 = new Personagem();
            jogador1.nome = "Carlos";
            jogador1.idade = 30;
            jogador1.armadura = "Face-Shield";
            jogador1.iA = "Pure Skill";
            jogador1.forca = 2;

            Personagem jogador2 = new Personagem();
            jogador2.nome = "Silva";
            jogador2.idade = 18;
            jogador2.armadura = "Capa de Chuva";
            jogador2.iA = "Stockfish";
            jogador1.forca = 3;

            Console.WriteLine($"Personagem 1: {jogador1.nome} / Armadura: {jogador1.armadura}");
            Console.WriteLine($"Personagem 2: {jogador2.nome} / Armadura {jogador2.armadura}");
            Console.WriteLine($"Partida: {jogador1.nome} VS {jogador2.nome}");

            //Luta

            jogador2.Defender(jogador2.Atacar2());
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Jogador 2 depois do ataque ficou com {jogador2.vida}");
            System.Threading.Thread.Sleep(500);
            
        }
    }
}
