using System;

namespace Abstração.Classes
{
    public abstract class Pagamento
    {
        private DateTime data;
        public DateTime Data{
            get;set;
        }
        protected double valor;
        public double Valor{
            get;set;
        }

        public string Cancelar(){
            return "";
        }

        public abstract string Desconto(int valor);
    }
}