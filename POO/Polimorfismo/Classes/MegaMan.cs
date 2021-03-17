using System;

namespace Polimorfismo.Classes
{
    public class MegaMan : Player
    {
        public override void Correr()
        {
            // base.Correr();
            Console.WriteLine("Correndo em velocidade 100x");
        }
        public void Correr(int multiplicador){
            //Esse aqui não é polimorfismo, apenas o de cima
        }
    }
}