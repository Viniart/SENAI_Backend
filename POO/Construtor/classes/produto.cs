namespace Construtor.classes
{
    public class produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }

        public produto(int codigo, string nome, string desc, int estoque){
            
            Codigo = codigo;
            Nome = nome;
            Descricao = desc;
            Estoque = estoque;
        }

        public produto(int codigo){
            Codigo = codigo;
        }
        
        public produto(){
            
        }
    }
}