using System;
using System.Collections.Generic;

namespace T.Classes
{
    public class Carrinho : ICarrinho
    {
        // ctrl + . -- Implementar Interface e GG!!

        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto _novoProduto)
        {
            // Lambda
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            // CTRL + D pra selecionar mais de 2 palavras iguais
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
            carrinho.Find(x => x.Codigo == _codigo).Codigo = _novoProduto.Codigo;
        }

        public void Cadastrar(Produto prod)
        {
            carrinho.Add(prod);
        }

        public void Delete(int _codigo)
        {
            Produto prodDelete = carrinho.Find(x => x.Codigo == _codigo);
            if(prodDelete != null)
            {
                carrinho.Remove(prodDelete);
            }
        }

        public void Listar()
        {
            foreach (Produto prod in carrinho)
            {
                Console.WriteLine("Produto : " + prod.Nome);
                // Console.WriteLine("Cod : " + prod.Codigo);
                // Console.WriteLine("Preco : " + "R$ " + prod.Preco);
            }
        }
    }
}