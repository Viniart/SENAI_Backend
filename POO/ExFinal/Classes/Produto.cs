using System;
using System.Collections.Generic;

namespace ExFinal.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario CadastradoPor = new Usuario();
        
        public List<Produto> ListaDeProdutos = new List<Produto>();
        
        // Métodos
        public void Cadastrar(){
            
            Produto novoProduto = new Produto();

            System.Console.WriteLine($"Digite o código do produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            System.Console.WriteLine($"Digite o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            System.Console.WriteLine($"Digite o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.Today;

            // Chamamos um método do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();

            // Utilizamos o próprio método construtor para atribuir um objeto completo de usuário
            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);

        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preco: {item.Preco}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastrado Por: {item.CadastradoPor.Nome}");
            }

            Console.ResetColor();
        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);
        }
        
    }
}