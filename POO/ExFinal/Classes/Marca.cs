using System;
using System.Collections.Generic;

namespace ExFinal.Classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Marca> ListaDeMarcas = new List<Marca>();
        
        // Métodos
        public Marca Cadastrar(){
            Marca novaMarca = new Marca();

            Console.WriteLine("Digite o código da marca: ");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca: ");
            novaMarca.NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.Today;

            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
        }

        public void Listar(){
            
            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome da Marca: {item.NomeMarca}");
                Console.WriteLine($"Data do Cadastro: {item.DataCadastro}");
            }

            Console.ResetColor();
        }

        public void Deletar(int _codigo){
                
            Marca marcaDelete = ListaDeMarcas.Find(x => x.Codigo == _codigo);
            ListaDeMarcas.Remove(marcaDelete);

        }
    }
}