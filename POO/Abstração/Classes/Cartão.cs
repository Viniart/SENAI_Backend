namespace Abstração.Classes
{
    public abstract class Cartão : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            return "";
        }

        public override string Desconto(int valor)
        {
            return "";
        }

        public abstract void Pagar(float valor);
    }
}