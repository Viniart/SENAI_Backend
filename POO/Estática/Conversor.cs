namespace Estática
{
    public class Conversor
    {
        private static float cotacaoDolar = 5.10f;

        public static float ConverterDolarParaReal(float valorEmDolar){
            return valorEmDolar * cotacaoDolar;
        }
        public static float ConverterRealParaDolar(float valorEmReal){
            return valorEmReal / cotacaoDolar;
        }
    }
}