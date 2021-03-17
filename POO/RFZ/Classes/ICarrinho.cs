namespace RFZ.Classes
{
    public interface ICarrinho
    {
        // CRUD
        public void AdicionarProduto(Produto produto);
        public void MostrarProdutos();
        public void AlterarProduto(int codigo, Produto novoProduto);
        public void DeletarProduto(Produto produto);
        public void MostrarTotal();

    }
}