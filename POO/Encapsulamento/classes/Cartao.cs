using System;

namespace Encapsulamento.classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{return numero;} // Capturar o valor
            set{numero = value;} // Definir o valor
        }
        private string nomeTitular;
        public string NomeTitular{
            set{nomeTitular = value;}
            get{return nomeTitular;}
        }
        private string bandeira;
        public string Bandeira{
            get{return bandeira;}
            set{bandeira = value;}
        }
        private string token = "qwertyui";
        public string Token{
            get{return bandeira;}
        }
        private string cvv;
        public string Cvv{get;set;}
        protected float limite = 5000;
        public float Limite{get;set;}

        //Métodos

        public string RegistrarCompra(bool validado){
            return "";
        }

    }
}