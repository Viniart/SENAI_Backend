namespace Aula_2
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public int forca;
        public string armadura;
        public string iA = "Jarvis";


        public int vida = 100;

        public int Atacar1(){

            return 10*forca;
        }
        public int Atacar2(){
            return 20*forca;
        }
        public string Defender(int ataque){

            if(this.vida <= 0){
                System.Console.WriteLine("O jogador morreu!");
            }else{
            this.vida = this.vida - ataque;
            }
            return "Não foi dessa vez";
            //N tem o using System no início(posso colocar)
            //USE O CTRL + . !! Pra colocar o using system/System.Console entre outros;
        }
    }
}