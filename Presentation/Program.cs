using System;
using System.Collections.Generic;
using Business.Services;
using Data.Produtos;
using Model;

namespace Presentation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a loja do Sovereigns of Nowhere!");
            Console.WriteLine("Pressione ENTER para adicionar um produto ao carrinho");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                CarrinhoService carrinho = new CarrinhoService();
                carrinho.AdicionarItem();
            }

            /*
            Console.WriteLine("Bem vindo a loja do Sovereigns of Nowhere!");
            Console.WriteLine("Confira a nossa lista de produtos:");
            var listaProdutos = new List<Produto>();

            var box = new Produto();
            box.Nome = "Caixa inicial";
            box.Descricao = "Uma caixa contendo o kit inicial do jogo.";
            box.Preco = 90;

            listaProdutos.Add(box);
          
            foreach (var prod in listaProdutos)
            {

                Console.WriteLine($"{prod.Nome} - R$ {prod.Preco}");
            }
            */


            /*
            var produtosBanco = new ListagemProduto();
            var produtos = produtosBanco.BuscarProdutos();

            foreach (var prod in produtos) 
            {

                Console.WriteLine($"{prod.Nome} - R$ {prod.Preco}");
            }
            */

        }
    }
}
