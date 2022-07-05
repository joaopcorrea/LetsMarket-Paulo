﻿using LetsMarket.Menu;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LetsMarket.Menu4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Arquivo.InicializarArquivos();
            var todos = Arquivo.BuscarTodos<Funcionarios>();
            var um = Arquivo.BuscarUm<Funcionarios>(1);


            Console.ResetColor();
            Console.Title = "Let's Store";

            var menu = new MenuItem("Menu Principal");

            var produtos = new MenuItem("Produtos");
            produtos.Add(new MenuItem("Cadastrar Produtos", Produtos.CadastrarProdutos));
            produtos.Add(new MenuItem("Listar Produtos", Produtos.ListarProdutos));

            var funcionarios = new MenuItem("Funcionários");
            funcionarios.Add(new MenuItem("Cadastrar Funcionários", Funcionarios.CadastrarFuncionarios));
            funcionarios.Add(new MenuItem("Listar Funcionários", Funcionarios.ListarFuncionarios));

            menu.Add(produtos);
            menu.Add(funcionarios);

            menu.Execute();
        }
    }
}