using System;

namespace Abstração.Classes
{
    public class Boleto : Pagamento
    {
        private float codigoDeBarras;
        public float CodigoDeBarras{
            get{return codigoDeBarras;}
        }

        public void Registrar(){
            Random randomico = new Random();
            this.codigoDeBarras = randomico.Next(0,300000001);
        }

        public void GerarBoleto(){
            double total = this.Valor - (this.Valor * 0.88);

            Console.WriteLine($"Valor do Boleto - R${total}");
            Console.WriteLine($"Data - {this.Data}");
            Console.WriteLine($"Data de Vencimento - {this.Data.AddDays(10)}");
            Console.WriteLine($"Código de Barras - {this.CodigoDeBarras}");
        }   

        public override string Desconto(int valor)
        {
            return "";
        }
    }
}