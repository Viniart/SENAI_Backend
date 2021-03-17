using System;
using System.Collections.Generic;
namespace ObjComoArgumento.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        // Criamos a lista de produtos, e a chamamos de carrinho
        List<Produto> carrinho = new List<Produto>();

        // Método para adicionar _produto para a lista carrinho
        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }

        public void MostrarProdutos() {
            ValorTotal = 0;
            if (carrinho != null)
            {
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }
        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }
        public void MostrarTotal(){
            if(carrinho != null){
                foreach(Produto item in carrinho)
                {
                    ValorTotal += item.Preco;
                }
                Console.WriteLine($"O total do carrinho é: R${ValorTotal}");
            }else
            {
                Console.WriteLine("Seu carrinho está vazio!");
            }
        }

        public void AlterarItem(int _codigo_procurado, Produto _novoProduto){
            carrinho.Find(x => x.Codigo == _codigo_procurado).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo_procurado).Preco = _novoProduto.Preco;
        }
    }
}