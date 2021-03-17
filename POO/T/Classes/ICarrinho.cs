namespace T.Classes
{
    public interface ICarrinho
    {
        //Interface só aceita métodos
        //Implementação CRUD:
        //Create

        void Cadastrar(Produto produto);

        //Read

        void Listar();

        //Update

        void Alterar(int _codigo, Produto _novoProduto);

        //Delete

        void Delete(int _codigo);

    }
}