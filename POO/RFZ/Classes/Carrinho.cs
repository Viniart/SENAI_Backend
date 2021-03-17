using System;
using System.Collections.Generic;

namespace RFZ.Classes
{
    public class Carrinho : ICarrinho
    {
        // Ctrl + . é a vida! (Implementar Interface!!)
        public float ValorTotal {get; set;}
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }
        public void MostrarProdutos(){
            if (carrinho != null)
            {
                foreach (Produto prod in carrinho)
                {
                    Console.WriteLine($"Código: {prod.Codigo}, Nome: {prod.Nome}, Preco: R${prod.Preco}");
                }
            }
        }
        public void AlterarProduto(int codigo, Produto novoProduto){
            carrinho.Find(x => x.Codigo == codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == codigo).Codigo = novoProduto.Codigo;
        }
        public void DeletarProduto(Produto produto){
            carrinho.Remove(produto);
        }
        public void MostrarTotal(){
            Console.ForegroundColor = ConsoleColor.Gray;
            ValorTotal = 0;
            if(carrinho != null)
            {
                foreach (Produto prod in carrinho)
                {
                ValorTotal += prod.Preco;
                }
                Console.WriteLine($"O valor total do carrinho é: R${ValorTotal}");
            }else{
                Console.WriteLine("Seu carrinnho está vazio!");
            }
            Console.ResetColor();
        }
    }
}