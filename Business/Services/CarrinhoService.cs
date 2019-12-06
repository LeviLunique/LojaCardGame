using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Business.Services
{
    public class CarrinhoService
    {
        public void AdicionarItem() 
        {
            var itemCarrinho = new Carrinho();

            if (itemCarrinho.Item == null)
            {
                var listaItens =  new List<Carrinho>();

                itemCarrinho.Item = "Caixa";
                itemCarrinho.Produto = new Produto ();

                var box = itemCarrinho.Produto;
                box.Nome = "Caixa inicial";
                box.Descricao = "Uma caixa contendo o kit inicial do jogo.";
                box.Preco = 90;

                itemCarrinho.Quantidade = 1;
                listaItens.Add(itemCarrinho);

                foreach (var itens in listaItens)
                {

                    Console.WriteLine($" O item {itens.Item} foi adicionado ao carrinho");

                }
            }
            else 
            {
                itemCarrinho.Quantidade++;
            }

        }
    }
}
