﻿using System;
using MVC_Console.Controllers;
using MVC_Console.Models;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            prod.ListarProdutos();
        }
    }
}
